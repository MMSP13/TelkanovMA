using AutoBase.Model;
using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoBase
{

    public partial class MainForm : Form
    {
        private Configuration myConfig;
       // private ISessionFactory mySessionFactory;
      //  private ISession mySession;
        public MainForm()
        {
            InitializeComponent();
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                AutoBase.Model.Predmet SendingCar = new AutoBase.Model.Predmet{ Name = textBox4.Text };
                PredAdd(SendingCar);               
            }
            catch (Exception ex)
            {              
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void PredAdd(Predmet Object)
        {
            using (ISession mySession = DBService.Factory.OpenSession())
            {
                mySession.BeginTransaction();
                mySession.Save(Object);
                mySession.Transaction.Commit();
                mySession.Flush();
            }
        }
        private void PredUpd(Predmet Object)
        {
            using (ISession mySession = DBService.Factory.OpenSession())
            {
                mySession.BeginTransaction();
                mySession.SaveOrUpdate(Object);
                mySession.Transaction.Commit();
                mySession.Flush();
            }
        }
        private void PredDel(Predmet Object)
        {
            using (ISession mySession = DBService.Factory.OpenSession())
            {
                mySession.BeginTransaction();
                mySession.Delete(Object);
                mySession.Transaction.Commit();
                mySession.Flush();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //AutoBase.Model.Engine SendingEngine = new AutoBase.Model.Engine { Name = "M50B25", Volume = "2.5", Torque = "250", Power = "192" };
                AutoBase.Model.Prepod SendingPrep = new AutoBase.Model.Prepod { Name = textBox1.Text, Surname = textBox2.Text, Patronymic = textBox3.Text };
                AddPrep(SendingPrep);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddPrep(Prepod Object)
        {
            using (ISession mySession = DBService.Factory.OpenSession())
            {
                mySession.BeginTransaction();
                mySession.Save(Object);
                mySession.Transaction.Commit();
                mySession.Flush();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //AutoBase.Model.Engine SendingEngine = new AutoBase.Model.Engine { Name = "M50B25", Volume = "2.5", Torque = "250", Power = "192" };
                AutoBase.Model.Prepod SendingPrep = new AutoBase.Model.Prepod { Id = Convert.ToInt16(textBox5.Text), Name = textBox1.Text, Surname = textBox2.Text, Patronymic = textBox3.Text };
                UpdPrep(SendingPrep);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                AutoBase.Model.Predmet predmet = new AutoBase.Model.Predmet {Id = Convert.ToInt16(textBox6.Text), Name = textBox4.Text };
                PredUpd(predmet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdPrep(Prepod Object)
        {
            using (ISession mySession = DBService.Factory.OpenSession())
            {
                mySession.BeginTransaction();
                mySession.SaveOrUpdate(Object);
                mySession.Transaction.Commit();
                mySession.Flush();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //AutoBase.Model.Engine SendingEngine = new AutoBase.Model.Engine { Name = "M50B25", Volume = "2.5", Torque = "250", Power = "192" };
                AutoBase.Model.Prepod SendingPrep = new AutoBase.Model.Prepod { Id = Convert.ToInt16(textBox5.Text) };
                DelPrep(SendingPrep);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DelPrep(Prepod Object)
        {
            using (ISession mySession = DBService.Factory.OpenSession())
            {
                mySession.BeginTransaction();
                mySession.Delete(Object);
                mySession.Transaction.Commit();
                mySession.Flush();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                AutoBase.Model.Predmet predmet = new AutoBase.Model.Predmet { Id = Convert.ToInt16(textBox6.Text) };
                PredDel(predmet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
}
