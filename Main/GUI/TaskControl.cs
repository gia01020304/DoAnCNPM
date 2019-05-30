﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.GUI
{
    public partial class TaskControl : UserControl
    {
        public bool IsRowClick
        {

            set
            {
                if(value == true)
                {
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnSave.Enabled = false;
                    btnCalcel.Enabled = false;
                }
                else
                {
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnAdd.Enabled = true;

                }
            }
        }

        public bool isSuccessFul { get; set; } = false;

        private event EventHandler addEvent;
        public event EventHandler AddEvent
        {
            add
            {
                addEvent += value;
            }
            remove
            {
                addEvent -= value;
            }
        }
        private event EventHandler editEvent;
        public event EventHandler EditEvent
        {
            add
            {
                editEvent += value;
            }
            remove
            {
                editEvent -= value;
            }
        }

        private event EventHandler deleteEvent;
        public event EventHandler DeleteEvent
        {
            add
            {
                deleteEvent += value;
            }
            remove
            {
                deleteEvent -= value;
            }
        }

        private event EventHandler saveEvent;
        public event EventHandler SaveEvent
        {
            add
            {
                saveEvent += value;
            }
            remove
            {
                saveEvent -= value;
            }
        }

        private event EventHandler calcelEvent;
        public event EventHandler CalcelEvent
        {
            add
            {
                calcelEvent += value;
            }
            remove
            {
                calcelEvent -= value;
            }
        }
        public TaskControl()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isSuccessFul = false;
            addEvent?.Invoke(this, EventArgs.Empty);
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnCalcel.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editEvent?.Invoke(this, EventArgs.Empty);
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnCalcel.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("Bạn có thật sự muốn xóa ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(rs == DialogResult.OK)
            {
                deleteEvent?.Invoke(this, EventArgs.Empty);
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveEvent?.Invoke(this, EventArgs.Empty);
            if(isSuccessFul == true)
            {
                btnAdd.Enabled = true;
                btnCalcel.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = false;
            }
        }

        private void btnCalcel_Click(object sender, EventArgs e)
        {
            calcelEvent?.Invoke(this, EventArgs.Empty);
            btnSave.Enabled = false;
            btnCalcel.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnAdd.Enabled = true;
        }
        public void showDelete()
        {
            btnAdd.Enabled = false;
            btnCalcel.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
        }
        public void visibleBtn()
        {
            btnAdd.Enabled = true;
            btnCalcel.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
        }
    }
}

