﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmClockApp.Forms
{
    public partial class AlarmForm : Form
    {
        public AlarmForm(int currentAlarmTimeID)
        {
            InitializeComponent(currentAlarmTimeID);
        }
    }
}
