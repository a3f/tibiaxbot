﻿/*
 *     TibiaXBot is a bot made for tibia, it has many new unique features
    that none has used before (Or not very much).
    Copyright (C) 2008  Jesper_Kladden & Aluwama.

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with TibiaXBot.  If not, see <http://www.gnu.org/licenses/>.
 * 
 */



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tibia;
using Tibia.Objects;

namespace TibiaXBot
{
    public partial class WASD : Form
    {
        public Player player;
        public Tibia.Objects.Console console;

        public WASD(Client client)
        {
            InitializeComponent();
        }
        private void WASD_Load(object sender, EventArgs e)
        {

        }

        private void buttonEnable_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonKeyboard_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonKeyboard.Checked)
            {
                buttonEnable.Enabled = false;
            }
            else
            {
                buttonEnable.Enabled = true;
            }
        }

        private void buttonCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonCheckBox.Checked)
            {
                buttonEnable.Enabled = true;
                InstallKBHook();
            }
            else
            {
                buttonEnable.Enabled = false;
            }
        }
    }
}
