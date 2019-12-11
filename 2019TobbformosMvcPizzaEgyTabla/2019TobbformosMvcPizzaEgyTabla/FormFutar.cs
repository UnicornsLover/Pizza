﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TobbbformosPizzaAlkalmazasEgyTabla.Repository;
using TobbbformosPizzaAlkalmazasEgyTabla.Model;
using System.Diagnostics;
using TobbbformosPizzaAlkalmazasEgyTabla.repository;

namespace _2019TobbformosMvcPizzaEgyTabla
{
    public partial class FormPizzaFutarKft : Form
    {
        /// <summary>
        /// Futárokat tartalmazó adattábla
        /// </summary>
        private DataTable futarDT = new DataTable();
        /// <summary>
        /// Tárolja a futarokat a listában
        /// </summary>
        private FRepository fr = new FRepository();

        bool ujAdatFel = false;

        private void ujMegsemGombokKezelese()
        {
            if (ujAdatFel == false)
            {
                return;
            }  
            if ((textBoxFutarNev.Text != string.Empty) || (textBoxFutarTel.Text != string.Empty))
            {
                buttonFutarUjMentes.Visible = true;
                buttonFutarMegsem.Visible = true;
            }
            else
            {
                buttonFutarUjMentes.Visible = false;
                buttonFutarMegsem.Visible = false;
            }
        }

        private void FutarGombokIndulaskor()
        {
            panelFutar.Visible = false;
            panelModositTorolGombok.Visible = false;
            if (dataGridViewFutar.SelectedRows.Count != 0)
            {
                buttonUjFutar.Visible = false;
            }
            else
            {
                buttonUjFutar.Visible = true;
            }
            buttonFutarMegsem.Visible = false;
            buttonFutarUjMentes.Visible = false;

        }

        private void beallitGombokatUjMegrendeloMegsemEsMentes()
        {
            if ((dataGridViewFutar.Rows != null) && (dataGridViewFutar.Rows.Count > 0))
            {
                dataGridViewFutar.Rows[0].Selected = true;
            }
            buttonFutarUjMentes.Visible = false;
            buttonFutarMegsem.Visible = false;
            panelModositTorolGombok.Visible = true;
            ujAdatFel = false;

            textBoxFutarNev.Text = string.Empty;
            textBoxFutarTel.Text = string.Empty;
        }

        private void beallitGombokatTextboxokatUjMegrendelonel()
        {
            panelFutar.Visible = true;
            panelModositTorolGombok.Visible = false;
            textBoxFutarNev.Text = string.Empty;
            textBoxFutarTel.Text = string.Empty;
        }

        private void KattintaskorGombok()
        {
            ujAdatFel = false;
            buttonFutarUjMentes.Visible = false;
            buttonFutarMegsem.Visible = false;
            panelModositTorolGombok.Visible = true;
            errorProviderFutarNeve.Clear();
            errorProviderFutarTel.Clear();
        }

        private void updateFutarDGV()
        {
            //Adattáblát feltölti a repoba lévő futár listából
            futarDT = fr.getPizzaDataTableFromList();
            //Pizza DataGridView-nak a forrása a futár adattábla
            dataGridViewFutar.DataSource = null;
            dataGridViewFutar.DataSource = futarDT;
        }


    }
}
