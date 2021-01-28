using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyFirstLayoutModels;
using MyFirstLayoutServices;

namespace MyFirstLayout.Pages.Material
{
    public class IndexModel : PageModel
    {
        private readonly IMaterialRespository MaterialRespository;
        public IEnumerable<PurchaseModel> PurchaseMaterial { get; set; }
        public IEnumerable<SegregatedModel> SegregatedMaterial { get; set; }
        public IEnumerable<UnsegregatedModel> UnsegregatedMaterial { get; set; }
        public IndexModel(IMaterialRespository MaterialRespository)
        {
            this.MaterialRespository = MaterialRespository;
        }

        public void OnGet()
        {
            PurchaseMaterial = MaterialRespository.GetPurchaseMaterial();
            SegregatedMaterial = MaterialRespository.GetSegregatedMaterial();
            UnsegregatedMaterial = MaterialRespository.GetUnsegregatedMaterial();
        }
    }
}
