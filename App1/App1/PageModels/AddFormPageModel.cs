using FreshMvvm;
using PropertyChanged;

namespace App1.PageModels
{
    [ImplementPropertyChanged]
    public class AddFormPageModel : FreshBasePageModel
    {
        public string Name { get; set; }
    }
}