#region License Information (GPL v3)

/*
    Copyright (c) Jaex

    This program is free software; you can redistribute it and/or
    modify it under the terms of the GNU General Public License
    as published by the Free Software Foundation; either version 2
    of the License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

    Optionally you can also view the license at <http://www.gnu.org/licenses/>.
*/

#endregion License Information (GPL v3)

using ShareX.HelpersLib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Automate
{
    public class FunctionManager
    {
        public static readonly Dictionary<string, Type> Functions = new Dictionary<string, Type>()
        {
            { "Func", typeof(Function) },
            { "Call", typeof(Function_Call) },
            { "Wait", typeof(Function_Wait) },
            { "KeyDown", typeof(Function_KeyDown) },
            { "KeyUp", typeof(Function_KeyUp) },
            { "KeyPress", typeof(Function_KeyPress) },
            { "KeyPressText", typeof(Function_KeyPressText) },
            { "MouseDown", typeof(Function_MouseDown) },
            { "MouseUp", typeof(Function_MouseUp) },
            { "MouseClick", typeof(Function_MouseClick) },
            { "MouseMove", typeof(Function_MouseMove) },
            { "MouseWheel", typeof(Function_MouseWheel) }
        };

        public List<Function> FunctionList { get; private set; }
        public int LineDelay { get; set; }

        private bool stopRequested;

        public void Start()
        {
            if (FunctionList != null)
            {
                stopRequested = false;
                Run();
            }
        }

        public void Start(string script)
        {
            Compile(script);
            Start();
        }

        public void Start(ScriptInfo scriptInfo)
        {
            if (scriptInfo != null)
            {
                LineDelay = scriptInfo.LineDelay;
                Compile(scriptInfo.Script);
                Start();
            }
        }

        public void Stop()
        {
            stopRequested = true;
        }

        public bool Compile(string script)
        {
            FunctionList = new List<Function>();

            string[] lines = script.Lines();

            foreach (string line in lines)
            {
                if (!string.IsNullOrEmpty(line))
                {
                    Tokenizer tokenizer = new Tokenizer();
                    tokenizer.AutoParseLiteral = true;
                    tokenizer.Keywords = Functions.Select(x => x.Key).ToArray();
                    List<Token> tokens = tokenizer.Tokenize(line);

                    if (tokens[0].Type == TokenType.Literal) // Comment?
                    {
                        continue;
                    }

                    int loop = 1;

                    if (tokens[0].Type == TokenType.Numeric) // Loop?
                    {
                        loop = int.Parse(tokens[0].Text);
                        tokens.RemoveAt(0);
                    }

                    if (tokens[0].Type == TokenType.Keyword) // Function?
                    {
                        string name = tokens[0].Text;
                        string[] parameters = tokens.Skip(1).Select(x => x.Text).ToArray();
                        Function tempFunction = GetFunction(name, parameters);

                        if (tempFunction != null)
                        {
                            tempFunction.FunctionManager = this;
                            tempFunction.Loop = loop;
                            FunctionList.Add(tempFunction);
                            continue;
                        }
                    }
                }

                FunctionList.Add(null);
            }

            foreach (Function function in FunctionList)
            {
                if (function != null)
                {
                    function.Prepare();
                }
            }

            return true;
        }

        public void Run(int startIndex = 0)
        {
            for (int i = startIndex; !stopRequested && i < FunctionList.Count; i++)
            {
                Function function = FunctionList[i];

                if (function == null)
                {
                    break;
                }

                if (function.Loop <= 0)
                {
                    while (!stopRequested)
                    {
                        function.Run();
                    }
                }
                else
                {
                    for (int count = 0; !stopRequested && count < function.Loop; count++)
                    {
                        function.Run();
                    }
                }
            }
        }

        public Function GetFunction(string name, string[] parameters)
        {
            if (Functions.ContainsKey(name))
            {
                Function func = (Function)Activator.CreateInstance(Functions[name]);
                func.Name = name;
                func.Parameters = parameters;
                return func;
            }

            return null;
        }

        public int FindFunctionIndex(string name)
        {
            for (int i = 0; i < FunctionList.Count; i++)
            {
                Function function = FunctionList[i];

                if (function != null && function.GetType() == typeof(Function) && function.Parameters[0].
                    Equals(name, StringComparison.InvariantCultureIgnoreCase))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}