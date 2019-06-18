using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_MVP_NewsPaper
{
    class Presenter
    {
        IView view;
        
        public List<NewsPaper> Papers { get; private set; }

        public Presenter(List<NewsPaper> somePapers)
        {
            Papers = somePapers;
            view = new ViewPapers(this);
        }

        //продавець додав газету на розкладку та оповістив про це 
        public void UpdateList(NewsPaper paper)
        {
            Papers.Add(paper);
            view.Display();
        }

        //перевірка кількості грошей та відмітка у формі податкової
        public bool Checkout(string name, int money)
        {
            foreach(NewsPaper p in Papers)
            {
                if (p.Name == name && p.TaxForm(money))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
