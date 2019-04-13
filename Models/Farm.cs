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
    }
}