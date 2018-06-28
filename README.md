# auto-repair-shop

---

### Description: This is a not\-so\-modular application I designed to be a calculator for an imaginary automotive repair shop. There are lots of constant variables, if statements, and multiplication. At the very end, it spits out a number that the customer must pay for their repairs.

![auto-shop](https://github.com/EnEmerson/auto-repair-shop/blob/master/resources/auto-shop.png)

```C#

namespace program9
{
    public partial class automotiveShop : Form
    {
        const double OIL_CHANGE = 26.00;
        const double REGULAR_OIL = 0.00;
        const double MIXED_OIL = 10.00;
        const double FULL_SYNTH = 20.00;
        const double LUBE_JOB = 18.00;
        const double INSPECTION = 15.00;
        const double MUFFLER = 100.00;
        const double TIRE_ROT = 20.00;
        const double NO_WASH = 0.00;
        const double COMP_WASH = 0.00;
        const double FULL_WASH = 6.00;
        const double PREM_WASH = 9.00;
        const double RAD_FLUSH = 30.00;
        const double TRANS_FLUSH = 80.00;
        const double PARTS_TAX = 1.06; //6 percent tax on all parts
        const double LABOR_RATE = 20.00;

        double serviceAndLabor;
        double laborTotal;
        double parts;
        double partsTax;
        double partsTotal;
        double grandTotal;

        public automotiveShop()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)  //exit button
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clearing all textboxes and labels
            partsInput.Text = "";
            laborInput.Text = "";
            servLabOutput.Text = "";
            partsTotalOutput.Text = "";
            taxOnParts.Text = "";
            grandTotalOutput.Text = "";
            noWashLabel.Visible = false;

            //clearing all checkboxes and radio buttons
            oilChange.Checked = false;
            lubeJob.Checked = false;
            regOil.Checked = false;
            mixedOil.Checked = false;
            synthOil.Checked = false;
            noWash.Checked = false;
            compWash.Checked = false;
            fullWash.Checked = false;
            premWash.Checked = false;
            radFlush.Checked = false;
            transFlush.Checked = false;
            inspection.Checked = false;
            repMuffler.Checked = false;
            tireRot.Checked = false;

            //clearing all variables
            clearVariables();

        }

        private void oilAndLube() //oil change or not
        {
            if (oilChange.Checked)
            {
                grandTotal += OIL_CHANGE;
                specialOil();
            }
            if (lubeJob.Checked)
                grandTotal += LUBE_JOB;
        }
        private void specialOil() //special type of oil, extra costs
        {
                if (regOil.Checked)
                    grandTotal += REGULAR_OIL;
                if (mixedOil.Checked)
                    grandTotal += MIXED_OIL;
                if (synthOil.Checked)
                    grandTotal += FULL_SYNTH;
        }
        private void miscJobs() //miscellanious jobs
        {
            if (inspection.Checked)
                grandTotal += INSPECTION;
            if (repMuffler.Checked)
                grandTotal += MUFFLER;
            if (tireRot.Checked)
                grandTotal += TIRE_ROT;
        }
        private void carWashType() //car wash or not
        {
            if (noWash.Checked)
                noWashLabel.Visible = true;
            if (compWash.Checked)
                grandTotal += COMP_WASH;
            if (fullWash.Checked)
                grandTotal += FULL_WASH;
            if (premWash.Checked)
                grandTotal += PREM_WASH;
        }
        private void flushType() //transmission/radiator flush
        {
            if (radFlush.Checked)
                grandTotal += RAD_FLUSH;
            if (transFlush.Checked)
                grandTotal += TRANS_FLUSH;
        }
        private void partsAndLaborCalc() //calculates parts and labor costs
        {
            try
            {
                parts = double.Parse(partsInput.Text);
                partsTotal = parts * PARTS_TAX;
                partsTax = partsTotal - parts;

                serviceAndLabor = double.Parse(laborInput.Text);
                laborTotal = serviceAndLabor * LABOR_RATE;

                grandTotal += partsTotal + laborTotal;
            }
            catch
            {
                MessageBox.Show("Input Error.");
                clearVariables();
                partsInput.Text = "";
                laborInput.Text = "";
            }
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            oilAndLube();
            miscJobs();
            carWashType();
            flushType();
            partsAndLaborCalc();

            servLabOutput.Text = laborTotal.ToString("C");
            partsTotalOutput.Text = partsTotal.ToString("C");
            taxOnParts.Text = partsTax.ToString("C");
            grandTotalOutput.Text = grandTotal.ToString("C");

            clearVariables();
        }

        private void automotiveShop_Load(object sender, EventArgs e)
        {
            noWashLabel.Visible = false;
        }

        private void clearVariables()
        {
            //clearing all variables
            serviceAndLabor = 0;
            parts = 0;
            partsTax = 0;
            grandTotal = 0;
            laborTotal = 0;
            partsTotal = 0;
        }
    }
}
```