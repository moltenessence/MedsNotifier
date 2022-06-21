using MedsNotifier.Data.Models;

namespace MedsNotifier
{
    public interface IMedsFactory
    {
        public MedsModel CreateMedicationFromForm(MedsModel medication);
    }
}
