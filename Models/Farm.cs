using System;
using System.Collections.Generic;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models
{
    public class Farm
    {
        private List<GrazingField> _grazingFields = new List<GrazingField>();
        private List<PlowedField> _plowedFields = new List<PlowedField>();
        private List<NaturalField> _naturalFields = new List<NaturalField>();
        private List<ChickenHouse> _chickenHouses = new List<ChickenHouse>();
        private List<DuckHouse> _duckHouses = new List<DuckHouse>();

        public void AddChickenHouse (ChickenHouse field)
        {
            _chickenHouses.Add(field);
        }

        public void AddDuckHouse (DuckHouse field)
        {
            _duckHouses.Add(field);
        }

        public void AddGrazingField (GrazingField field)
        {
            _grazingFields.Add(field);
        }

        public void AddPlowedField (PlowedField field)
        {
            _plowedFields.Add(field);
        }

        public void AddNaturalField (NaturalField field)
        {
            _naturalFields.Add(field);
        }

        public override string ToString()
        {
            return $@"
{_plowedFields.Count} plowed fields.
{_naturalFields.Count} natural fields.
{_grazingFields.Count} grazing fields.
{this._chickenHouses.Count} chicken houses.
{this._duckHouses.Count} duck houses.
            ";
        }
    }
}