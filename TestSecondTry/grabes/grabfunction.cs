﻿namespace TestSecondTry.grabes
{
    using System.Collections.Generic;
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
            if (grablist != null)
            {
                grabes.Id  += 1;

                grablist.Add(grabes);
            }
            else
            {
                grabes.Id = 0;

                grablist.Add(grabes);
            }
        }

        public void DeleteGrab(int id)
        {
            grablist.RemoveAt(id);
        }

    }
}
