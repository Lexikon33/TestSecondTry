namespace TestSecondTry.grabes
{
    using System.Collections.Generic;
    using System.Security.AccessControl;
    using TestSecondTry.model;

    public class grabfunction
    {
        private List<grabmodel> grablist = new List<grabmodel>(); 

        public List<grabmodel> reGrab()
        {
            return grablist;
        }

        public void AddGrab(grabmodel grabes)
        {
            grabes.Id = grablist.Any() ? grablist.Max(t => t.Id) + 1 : 1;

            grablist.Add(grabes);
        }

        public void DeleteGrab(int grabId)
        {
            var grabs = grablist.FirstOrDefault(t => t.Id == grabId);
            
            grablist.Remove(grabs);            
        }

    }
}
