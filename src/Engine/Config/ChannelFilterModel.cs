/*
 * $Id: PreferencesDialog.cs 142 2007-01-02 22:19:08Z meebey $
 * $URL: svn+ssh://svn.qnetp.net/svn/smuxi/smuxi/trunk/src/Frontend-GNOME/PreferencesDialog.cs $
 * $Rev: 142 $
 * $Author: meebey $
 * $Date: 2007-01-02 23:19:08 +0100 (Tue, 02 Jan 2007) $
 *
 * Smuxi - Smart MUltipleXed Irc
 *
 * Copyright (c) 2005-2006 Mirco Bauer <meebey@meebey.net>
 *
 * Full GPL License: <http://www.gnu.org/licenses/gpl.txt>
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307 USA
 */

using System;
using Smuxi;
using Smuxi.Common;

namespace Smuxi.Engine
{
    public class ChannelFilterModel
    {
        private string _Pattern;
        private bool   _FilterJoins;
        private bool   _FilterParts;
        private bool   _FilterQuits;
        
        public string Pattern {
            get {
                return _Pattern;
            }
            set {
                _Pattern = value;
            }
        }
        
        public bool FilterJoins {
            get {
                return _FilterJoins;
            }
            set {
                _FilterJoins = value;
            }
        }
        
        public bool FilterParts {
            get {
                return _FilterParts;
            }
            set {
                _FilterParts = value;
            }
        }
        
        public bool FilterQuits {
            get {
                return _FilterQuits;
            }
            set {
                _FilterQuits = value;
            }
        }
        
        public ChannelFilterModel()
        {
        }
    }
}
