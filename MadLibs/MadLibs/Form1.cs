using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadLibs
{
    public partial class MadLibs : Form
    {
        public MadLibs()
        {
            InitializeComponent();
        }

        private void btnMakeMadLib_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            int c;
            string color, wordEndingInEst, pluralBodyPart, animal, noun, pluralNoun;

            a = Convert.ToInt32(txtInt1.Text);
            b = Convert.ToInt32(txtInt2.Text);
            c = a - b;

            color = Convert.ToString(txtColorInput.Text);
            wordEndingInEst = Convert.ToString(txtEstInput.Text);
            pluralBodyPart = Convert.ToString(txtBodyPartInput.Text);
            animal = Convert.ToString(txtAnimalInput.Text);
            noun = Convert.ToString(txtNounInput.Text);
            pluralNoun = Convert.ToString(txtPluralNoun.Text);

            txtColorInput.Visible = false;
            txtEstInput.Visible = false;
            txtBodyPartInput.Visible = false;
            txtAnimalInput.Visible = false;
            txtNounInput.Visible = false;
            txtPluralNoun.Visible = false;
            txtInt1.Visible = false;
            txtInt2.Visible = false;

            lblColor.Visible = false;
            lblWordEst.Visible = false;
            lblPluralBodyPart.Visible = false;
            lblAnimal.Visible = false;
            lblNoun.Visible = false;
            lblPluralNoun.Visible = false;
            lblInt1.Visible = false;
            lblInt2.Visible = false;
            btnMakeMadLib.Visible = false;

            pictureBoxDragon.Visible = true;
            lblMadLibOutput.Visible = true;
            lblMadLibOutput.Text = "The " + color + " Dragon is the " + wordEndingInEst + " of all. It has a " + c + " " + pluralBodyPart + ", and a " + animal + " shaped like a " +
                noun + ". It loves to eat " + pluralNoun + ", although it will feast on nearly anything.";
        





        }
    }
}
