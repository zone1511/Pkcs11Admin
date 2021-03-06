﻿/*
 *  Pkcs11Admin - GUI tool for administration of PKCS#11 enabled devices
 *  Copyright (c) 2014-2015 Jaroslav Imrich <jimrich@jimrich.sk>
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License version 3 
 *  as published by the Free Software Foundation.
 *  
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *  
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using Be.Windows.Forms;
using System;
using System.Windows.Forms;

namespace Net.Pkcs11Admin.WinForms.Dialogs
{
    public partial class HexEditor : Form
    {
        private DynamicByteProvider _dynamicByteProvider = null;

        public byte[] Bytes
        {
            get
            {
                return _dynamicByteProvider.Bytes.ToArray();
            }
        }

        public HexEditor(string name, byte[] bytes)
        {
            InitializeComponent();

            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("name");

            if (bytes == null)
                throw new ArgumentNullException("bytes");

            TextBoxName.Text = name;

            _dynamicByteProvider = new DynamicByteProvider(bytes);
            HexBoxEditor.ByteProvider = _dynamicByteProvider;
        }
    }
}
