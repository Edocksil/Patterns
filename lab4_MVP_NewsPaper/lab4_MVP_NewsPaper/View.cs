using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_MVP_NewsPaper
{
    class ViewPapers : IView
    {
        Presenter presenter;

        public ViewPapers(Presenter somePresenter)
        {
            presenter = somePresenter;
        }

        public void Display()
        {
            Console.WriteLine("Choose a NewsPaper: ");
            foreach (NewsPaper paper in presenter.Papers)
            {
                Console.WriteLine(paper.ToString());
            }
        }

        //процес покупки та отримання газети покупцем
        public void Buy(string name, int payment)
        {
            Console.WriteLine();
            if (presenter.Checkout(name, payment)) Console.WriteLine("Take your: " + name);
            else Console.WriteLine("Not enough money for " + name);
            Console.WriteLine();
        }
    }
}
