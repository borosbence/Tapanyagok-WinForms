using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tapanyagok.Models;
using Tapanyagok.Repositories;
using Tapanyagok.ViewInterfaces;

namespace Tapanyagok.Presenters
{
    public class TablazatPresenter
    {
        private ITablazatView view;
        private TapanyagRepository repo = new TapanyagRepository();
        public TablazatPresenter(ITablazatView param)
        {
            view = param;
        }

        public void LoadData()
        {
            view.bindingList = repo.GetAllTapanyag(
                view.pageNumber, view.itemsPerPage, view.search, view.sortBy, view.ascending);
            view.totalItems = repo.Count();
        }

        public void Add(tapanyag tapanyag)
        {
            if (view.bindingList.Any(x => x.nev == tapanyag.nev))
            {
                throw new Exception("Már létezik ilyen névvel tápanyag!");
            }
            else
            {
                view.bindingList.Insert(0,tapanyag);
                repo.Insert(tapanyag);
            }
        }

        public void Remove(int index)
        {
            var tapanyag = view.bindingList.ElementAt(index);
            view.bindingList.RemoveAt(index);
            if (tapanyag.id > 0)
            {
                repo.Delete(tapanyag.id);
            }
        }

        public void Modify(int index, tapanyag tapanyag)
        {
            view.bindingList[index] = tapanyag;
            repo.Update(tapanyag);
        }

        public void Save()
        {
            repo.Save();
        }
    }
}
