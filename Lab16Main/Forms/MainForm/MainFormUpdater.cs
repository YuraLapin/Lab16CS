using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16Main
{
    public class MainFormUpdater
    {
        public void UpdateCollectionTextBox(MainForm form)
        {
            IEnumerable<Transport> ans;

            if (form.nameFilterRadioButton.Checked)
            {
                ans = from element in Program.list where element.Name == form.nameFilterTextBox.Text select element;
            }
            else if (form.powerFilterRadioButton.Checked)
            {
                if (form.powerFilterTextBox.Text != "" && UserInteractor.IsInt(form.powerFilterTextBox.Text) && form.powerFilterTextBox.Text.Count() <= 10)
                {
                    ans = from element in Program.list where element.Power == int.Parse(form.powerFilterTextBox.Text) select element;
                }
                else
                {
                    ans = new List<Transport>();
                }
            }
            else
            {
                ans = from element in Program.list select element;
            }

            if (form.nameSortingRadioButton.Checked)
            {
                ans = ans.OrderBy(element => element.Name);
            }
            else if (form.powerSortingRadioButton.Checked)
            {
                ans = ans.OrderBy(element => element.Power);
            }

            form.collectionTextBox.Text = Extensions.ToString(ans);
        }
    }
}
