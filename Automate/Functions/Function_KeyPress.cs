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

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Automate
{
    public class Function_KeyPress : Function_Method
    {
        public override void Method()
        {
            if (Parameters.Length > 1)
            {
                VirtualKeyCode keyCode = (VirtualKeyCode)(Keys)Enum.Parse(typeof(Keys), Parameters[Parameters.Length - 1], true);

                List<VirtualKeyCode> modifiers = new List<VirtualKeyCode>();

                for (int i = 0; i < Parameters.Length - 1; i++)
                {
                    VirtualKeyCode vk;

                    string parameter = Parameters[i];

                    if (parameter.Equals("shift", StringComparison.InvariantCultureIgnoreCase))
                    {
                        vk = VirtualKeyCode.SHIFT;
                    }
                    else if (parameter.Equals("ctrl", StringComparison.InvariantCultureIgnoreCase) || parameter.Equals("control", StringComparison.InvariantCultureIgnoreCase))
                    {
                        vk = VirtualKeyCode.CONTROL;
                    }
                    else if (parameter.Equals("alt", StringComparison.InvariantCultureIgnoreCase) || parameter.Equals("menu", StringComparison.InvariantCultureIgnoreCase))
                    {
                        vk = VirtualKeyCode.MENU;
                    }
                    else
                    {
                        return;
                    }

                    modifiers.Add(vk);
                }

                InputHelpers.SendKeyPressModifiers(keyCode, modifiers.ToArray());
            }
            else
            {
                VirtualKeyCode keyCode = (VirtualKeyCode)(Keys)Enum.Parse(typeof(Keys), Parameters[0], true);
                InputHelpers.SendKeyPress(keyCode);
            }
        }
    }
}