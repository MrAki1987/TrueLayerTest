using Newtonsoft.Json;
using System.Collections.Generic;

namespace TrueLayerTest.Library.Model
{

    public  class PokemonModel
    {
        public class Color
        {
            [JsonProperty("name")]
            public string name { get; set; }
            [JsonProperty("url")]
            public string url { get; set; }
        }

        public class EggGroup
        {
            [JsonProperty("name")]
            public string name { get; set; }
            [JsonProperty("url")]
            public string url { get; set; }
        }

        public class EvolutionChain
        {
            [JsonProperty("url")]
            public string url { get; set; }
        }

        public class EvolvesFromSpecies
        {
            [JsonProperty("name")]
            public string name { get; set; }
            [JsonProperty("url")]
            public string url { get; set; }
        }

        public class Language
        {
            [JsonProperty("name")]
            public string name { get; set; }
            [JsonProperty("url")]
            public string url { get; set; }
        }

        public class Version
        {
            [JsonProperty("name")]
            public string name { get; set; }
            [JsonProperty("url")]
            public string url { get; set; }
        }

        public class FlavorTextEntry
        {
            [JsonProperty("flavor_text")]
            public string flavor_text { get; set; }
            [JsonProperty("language")]
            public Language language { get; set; }
            [JsonProperty("version")]
            public Version version { get; set; }
        }

        public class Genera
        {
            [JsonProperty("genus")]
            public string genus { get; set; }
            [JsonProperty("language")]
            public Language language { get; set; }
        }

        public class Generation
        {
            [JsonProperty("name")]
            public string name { get; set; }
            [JsonProperty("url")]
            public string url { get; set; }
        }

        public class GrowthRate
        {
            [JsonProperty("name")]
            public string name { get; set; }
            [JsonProperty("url")]
            public string url { get; set; }
        }

        public class Habitat
        {
            [JsonProperty("name")]
            public string name { get; set; }
            [JsonProperty("url")]
            public string url { get; set; }
        }

        public class Name
        {
            [JsonProperty("language")]
            public Language language { get; set; }
            [JsonProperty("name")]
            public string name { get; set; }
        }

        public class Area
        {
            [JsonProperty("name")]
            public string name { get; set; }
            [JsonProperty("url")]
            public string url { get; set; }
        }

        public class PalParkEncounter
        {
            [JsonProperty("area")]
            public Area area { get; set; }
            [JsonProperty("base_score")]
            public int base_score { get; set; }
            [JsonProperty("rate")]
            public int rate { get; set; }
        }

        public class Pokedex
        {
            [JsonProperty("name")]
            public string name { get; set; }
            [JsonProperty("url")]
            public string url { get; set; }
        }

        public class PokedexNumber
        {
            [JsonProperty("entry_number")]
            public int entry_number { get; set; }
            [JsonProperty("pokedex")]
            public Pokedex pokedex { get; set; }
        }

        public class Shape
        {
            [JsonProperty("name")]
            public string name { get; set; }
            [JsonProperty("url")]
            public string url { get; set; }
        }

        public class Pokemon
        {
            [JsonProperty("name")]
            public string name { get; set; }
            [JsonProperty("url")]
            public string url { get; set; }
        }

        public class Variety
        {
            [JsonProperty("is_default")]
            public bool is_default { get; set; }
            [JsonProperty("pokemon")]
            public Pokemon pokemon { get; set; }
        }

        public class Root
        {
            [JsonProperty("base_happiness")]
            public int base_happiness { get; set; }
            [JsonProperty("capture_rate")]
            public int capture_rate { get; set; }
            [JsonProperty("color")]
            public Color color { get; set; }
            [JsonProperty("egg_groups")]
            public List<EggGroup> egg_groups { get; set; }
            [JsonProperty("evolution_chain")]
            public EvolutionChain evolution_chain { get; set; }
            [JsonProperty("evolves_from_species")]
            public EvolvesFromSpecies evolves_from_species { get; set; }
            [JsonProperty("flavor_text_entries")]
            public List<FlavorTextEntry> flavor_text_entries { get; set; }
            [JsonProperty("form_descriptions")]
            public List<object> form_descriptions { get; set; }
            [JsonProperty("forms_switchable")]
            public bool forms_switchable { get; set; }
            [JsonProperty("gender_rate")]
            public int gender_rate { get; set; }
            [JsonProperty("genera")]
            public List<Genera> genera { get; set; }
            [JsonProperty("generation")]
            public Generation generation { get; set; }
            [JsonProperty("growth_rate")]
            public GrowthRate growth_rate { get; set; }
            [JsonProperty("habitat")]
            public Habitat habitat { get; set; }
            [JsonProperty("has_gender_differences")]
            public bool has_gender_differences { get; set; }
            [JsonProperty("hatch_counter")]
            public int hatch_counter { get; set; }
            [JsonProperty("id")]
            public int id { get; set; }
            [JsonProperty("is_baby")]
            public bool is_baby { get; set; }
            [JsonProperty("is_legendary")]
            public bool is_legendary { get; set; }
            [JsonProperty("is_mythical")]
            public bool is_mythical { get; set; }
            [JsonProperty("name")]
            public string name { get; set; }
            [JsonProperty("names")]
            public List<Name> names { get; set; }
            [JsonProperty("order")]
            public int order { get; set; }
            [JsonProperty("pal_park_encounters")]
            public List<PalParkEncounter> pal_park_encounters { get; set; }
            [JsonProperty("pokedex_numbers")]
            public List<PokedexNumber> pokedex_numbers { get; set; }
            [JsonProperty("shape")]
            public Shape shape { get; set; }
            [JsonProperty("varieties")]
            public List<Variety> varieties { get; set; }

        }
    }
   

}
