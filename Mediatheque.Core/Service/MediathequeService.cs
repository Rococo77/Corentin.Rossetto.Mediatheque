using Mediatheque.Core.Model;

namespace Mediatheque.Core.Service
{
    public class MediathequeService
    {
        private List<ObjetDePret> _fondDeCommerce = new List<ObjetDePret>();
        private INotationService _notationService;

        public MediathequeService(INotationService notationService)
        {
            _notationService = notationService;
        }

        public void AddObjet(ObjetDePret objet)
        {
            _fondDeCommerce.Add(objet);
        }

        public int GetNombreObjet()
        {
            return _fondDeCommerce.Count;
        }

        public List<string> PresentationCD()
        {
            List<string> descriptionsCDs = new List<string>();

            if (this.GetNombreObjet() == 0)
            {
                descriptionsCDs.Add("Pas de CD à afficher");
            } else
            {
                descriptionsCDs.Add("Presentation des CDs:");
            }

            for (int i = 0; i < _fondDeCommerce.Count; i++)
            {
                if (_fondDeCommerce[i] is CD)
                {
                    descriptionsCDs.Add($"Album: {_fondDeCommerce[i].TitreDeLObjet} Note: {_notationService.GetNoteAlbum(_fondDeCommerce[i].TitreDeLObjet)}");
                };
            }

            return descriptionsCDs;
        }
    }
}
