using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Envelope_Internal.Indigent.Models;
using Envelope_Internal.Indigent.Services;

namespace Envelope_Internal.Indigent.ViewModels
{
    /*
    public class AssignmentListViewModel : INotifyPropertyChanged
    {
        private AssignmentList _AssignmentList;

        public AssignmentList AssignmentList
        {
            get { return _AssignmentList; }
            set
            {
                _AssignmentList = value;
                OnPropertyChanged();
            }
        }

    
        public async Task SetAssignmentListAsync()
        {
            var AssignmentListServices = new AssignmentListServices();

            AssignmentList = await AssignmentListServices.GetAssignmentListAsync();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }

    */
}
