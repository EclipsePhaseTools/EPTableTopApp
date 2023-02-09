using EPTools.Models;

namespace EPTools.Services
{
    public interface IEPDataService
    {
        Task<List<Aptitude>> GetAptitudes();
        Task<List<Aptitude_Template>> GetAptitudeTemplates();
        Task<List<Background>> GetBackgrounds();
        Task<List<Career>> GetCareers();
        Task<List<CharGen>> GetCharGen();
        Task<List<Faction>> GetFactions();
        Task<List<GearArmor>> GetGearArmors();
        Task<List<GearBot>> GetGearBots();
        Task<List<GearCategories>> GetGearCategories();
        Task<List<GearComms>> GetGearComms();
        Task<List<GearCreature>> GetGearCreatures();
        Task<List<GearDrug>> GetGearDrugs();
        Task<List<GearItem>> GetGearItems();
        Task<List<GearMission>> GetGearMission();
        Task<List<GearNano>> GetGearNano();
        Task<List<GearPack>> GetGearPacks();
        Task<List<GearSecurity>> GetGearSecurity();
        Task<List<GearSoftware>> GetGearSoftware();
        Task<List<GearSwarm>> GetGearSwarms();
        Task<List<GearVehicle>> GetGearVehicles();
        Task<List<GearWare>> GetGearWare();
        Task<List<Morph>> GetMorphs();
    }

    public class EPDataService : IEPDataService
    {
        private readonly FetchService _fetchService;

        private List<Aptitude> _aptitudes;
        private List<Aptitude_Template> _aptitude_templates;
        private List<Background> _backgrounds;
        private List<Career> _careers;
        private List<CharGen> _chargen;
        private List<Faction> _factions;
        private List<GearArmor> _gear_armors;
        private List<GearBot> _gear_bots;
        private List<GearCategories> _gear_categories;
        private List<GearComms> _gear_comms;
        private List<GearCreature> _gear_creatures;
        private List<GearDrug> _gear_drugs;
        private List<GearItem> _gear_items;
        private List<GearMission> _gear_mission;
        private List<GearNano> _gear_nano;
        private List<GearPack> _gear_packs;
        private List<GearSecurity> _gear_security;
        private List<GearSoftware> _gear_software;
        private List<GearSwarm> _gear_swarms;
        private List<GearVehicle> _gear_vehicles;
        private List<GearWare> _gear_ware;
        private List<Morph> _morphs;

        public async Task<List<Aptitude>> GetAptitudes()
        {
            if (_aptitudes == null)
            {
                _aptitudes = await _fetchService.GetTFromEPFileAsync<List<Aptitude>>("aptitudes");
            }
            return _aptitudes;
        }

        public async Task<List<Aptitude_Template>> GetAptitudeTemplates()
        {
            if (_aptitude_templates == null)
            {
                _aptitude_templates = await _fetchService.GetTFromEPFileAsync<List<Aptitude_Template>>("aptitude_templates");
            }
            return _aptitude_templates;
        }

        public async Task<List<Background>> GetBackgrounds()
        {
            if (_backgrounds == null)
            {
                _backgrounds = await _fetchService.GetTFromEPFileAsync<List<Background>>("backgrounds");
            }
            return _backgrounds;
        }

        public async Task<List<Career>> GetCareers()
        {
            if (_careers == null)
            {
                _careers = await _fetchService.GetTFromEPFileAsync<List<Career>>("careers");
            }
            return _careers;
        }

        public async Task<List<CharGen>> GetCharGen()
        {
            if (_chargen == null)
            {
                _chargen = await _fetchService.GetTFromEPFileAsync<List<CharGen>>("chargen");
            }
            return _chargen;
        }

        public async Task<List<Faction>> GetFactions()
        {
            if (_factions == null)
            {
                _factions = await _fetchService.GetTFromEPFileAsync<List<Faction>>("factions");
            }
            return _factions;
        }

        public async Task<List<GearArmor>> GetGearArmors()
        {
            if (_gear_armors == null)
            {
                _gear_armors = await _fetchService.GetTFromEPFileAsync<List<GearArmor>>("gear_armor");
            }
            return _gear_armors;
        }

        public async Task<List<GearBot>> GetGearBots()
        {
            if (_gear_bots == null)
            {
                _gear_bots = await _fetchService.GetTFromEPFileAsync<List<GearBot>>("gear_bots");
            }
            return _gear_bots;
        }

        public async Task<List<GearCategories>> GetGearCategories()
        {
            if (_gear_categories == null)
            {
                _gear_categories = await _fetchService.GetTFromEPFileAsync<List<GearCategories>>("gear_categories");
            }
            return _gear_categories;
        }

        public async Task<List<GearComms>> GetGearComms()
        {
            if (_gear_comms == null)
            {
                _gear_comms = await _fetchService.GetTFromEPFileAsync<List<GearComms>>("gear_comms");
            }
            return _gear_comms;
        }

        public async Task<List<GearCreature>> GetGearCreatures()
        {
            if (_gear_creatures == null)
            {
                _gear_creatures = await _fetchService.GetTFromEPFileAsync<List<GearCreature>>("gear_creatures");
            }
            return _gear_creatures;
        }

        public async Task<List<GearDrug>> GetGearDrugs()
        {
            if (_gear_drugs == null)
            {
                _gear_drugs = await _fetchService.GetTFromEPFileAsync<List<GearDrug>>("gear_drugs");
            }
            return _gear_drugs;
        }

        public async Task<List<GearItem>> GetGearItems()
        {
            if (_gear_items == null)
            {
                _gear_items = await _fetchService.GetTFromEPFileAsync<List<GearItem>>("gear_items");
            }
            return _gear_items;
        }

        public async Task<List<GearMission>> GetGearMission()
        {
            if (_gear_mission == null)
            {
                _gear_mission = await _fetchService.GetTFromEPFileAsync<List<GearMission>>("gear_mission");
            }
            return _gear_mission;
        }

        public async Task<List<GearNano>> GetGearNano()
        {
            if (_gear_nano == null)
            {
                _gear_nano = await _fetchService.GetTFromEPFileAsync<List<GearNano>>("gear_nano");
            }
            return _gear_nano;
        }

        public async Task<List<GearPack>> GetGearPacks()
        {
            if (_gear_packs == null)
            {
                _gear_packs = await _fetchService.GetTFromEPFileAsync<List<GearPack>>("gear_packs");
            }
            return _gear_packs;
        }

        public async Task<List<GearSecurity>> GetGearSecurity()
        {
            if (_gear_security == null)
            {
                _gear_security = await _fetchService.GetTFromEPFileAsync<List<GearSecurity>>("gear_security");
            }
            return _gear_security;
        }

        public async Task<List<GearSoftware>> GetGearSoftware()
        {
            if (_gear_software == null)
            {
                _gear_software = await _fetchService.GetTFromEPFileAsync<List<GearSoftware>>("gear_software");
            }
            return _gear_software;
        }

        public async Task<List<GearSwarm>> GetGearSwarms()
        {
            if (_gear_swarms == null)
            {
                _gear_swarms = await _fetchService.GetTFromEPFileAsync<List<GearSwarm>>("gear_swarms");
            }
            return _gear_swarms;
        }

        public async Task<List<GearVehicle>> GetGearVehicles()
        {
            if (_gear_vehicles == null)
            {
                _gear_vehicles = await _fetchService.GetTFromEPFileAsync<List<GearVehicle>>("gear_vehicles");
            }
            return _gear_vehicles;
        }

        public async Task<List<GearWare>> GetGearWare()
        {
            if (_gear_ware == null)
            {
                _gear_ware = await _fetchService.GetTFromEPFileAsync<List<GearWare>>("gear_ware");
            }
            return _gear_ware;
        }

        public async Task<List<Morph>> GetMorphs()
        {
            if (_morphs == null)
            {
                _morphs = await _fetchService.GetTFromEPFileAsync<List<Morph>>("morphs");
            }
            return _morphs;
        }

        public EPDataService(FetchService fetchService)
        {
            _fetchService = fetchService;
        }
    }
}
