using System.Collections;
using System.Text;
using PAT.Models.Entities;
using PAT.Models.Entities.Enums;
using PAT.Models.Repositories;
using PAT.Models.Repositories.Interfaces;
using PAT.Views;

namespace PAT
{
    public partial class App
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IAdminRepository _adminRepository;
        private readonly ITeacherRepository _teacherRepository;
        private readonly IProgramRepository _programRepository;
        private readonly IStudentTypeRepository _studentTypeRepository;
        private readonly ICourseRepository _courseRepository;
        
        public App(
            IProgramRepository programRepository,
            IStudentRepository studentRepository, 
            IAdminRepository adminRepository, 
            ITeacherRepository teacherRepository,
            IStudentTypeRepository studentTypeRepository, 
            ICourseRepository courseRepository)
        {
            InitializeComponent();

            _programRepository = programRepository;
            _studentRepository = studentRepository;
            _adminRepository = adminRepository;
            _teacherRepository = teacherRepository;
            _studentTypeRepository = studentTypeRepository;
            _courseRepository = courseRepository;

            var loadData = LoadData();

            MainPage = new AppShell();
        }

        private async Task LoadData()
        {

            ICollection<Course> troncCommun = new Course[]{};
            ICollection<Course> scienceNat = new Course[]{};
            ICollection<Course> informatique = new Course[]{};
            ICollection<Course> commercialisationMode = new Course[]{};
            ICollection<Course> histoire = new Course[]{};
            ICollection<Course> designInterieur = new Course[]{};
            ICollection<Course> graphisme = new Course[]{};

            Models.Entities.Program? scienceNatProgram = null;
            Models.Entities.Program? infoProgram = null;
            Models.Entities.Program? commercialisationModeProgram = null;
            Models.Entities.Program? histoireProgram = null;
            Models.Entities.Program? productionModeProgram = null;
            Models.Entities.Program? designInterieurProgram = null;
            Models.Entities.Program? graphismeProgram = null;

            
            
            // ==== STUDENT TYPES ====
            var studentTypes = await _studentTypeRepository.GetAllAsync();
            var enumerable = studentTypes as StudentType[] ?? studentTypes.ToArray();
            if (!enumerable.Any())
            {
                await _studentTypeRepository.CreateAsync(new StudentType {StudentTypeName = "TUTOR" });
                await _studentTypeRepository.CreateAsync(new StudentType {StudentTypeName = "TUTEE" });
            }
            
            // ==== COURSES ====

            var courses = await _courseRepository.GetAllAsync();
            if (!courses.Any())
            { 
                // Tronc commun
                troncCommun.Add(await _courseRepository.CreateAsync(new Course { IsDeleted = false, CourseCode = "604-COM-CM", CourseCredits = 2, CourseName = "Anglais 1" }));
                troncCommun.Add(await _courseRepository.CreateAsync(new Course { IsDeleted = false, CourseCode = "604-PRO-PU", CourseCredits = 2, CourseName = "Anglais 2" }));
                troncCommun.Add(await _courseRepository.CreateAsync(new Course { IsDeleted = false, CourseCode = "340-101-MQ", CourseCredits = 2.33, CourseName = "Philosophie 1" }));
                troncCommun.Add(await _courseRepository.CreateAsync(new Course { IsDeleted = false, CourseCode = "340-102-MQ", CourseCredits = 2, CourseName = "Philosophie 2" }));
                troncCommun.Add(await _courseRepository.CreateAsync(new Course { IsDeleted = false, CourseCode = "340-103-MQ", CourseCredits = 2, CourseName = "Philosophie 3" }));
                troncCommun.Add(await _courseRepository.CreateAsync(new Course { IsDeleted = false, CourseCode = "109-101-MQ", CourseCredits = 1, CourseName = "Éducation Physique 1" }));
                troncCommun.Add(await _courseRepository.CreateAsync(new Course { IsDeleted = false, CourseCode = "109-102-MQ", CourseCredits = 1, CourseName = "Éducation Physique 2" }));
                troncCommun.Add(await _courseRepository.CreateAsync(new Course{ IsDeleted = false, CourseCode = "109-103-MQ", CourseCredits = 1, CourseName = "Éducation Physique 3" })); 
                troncCommun.Add(await _courseRepository.CreateAsync(new Course { IsDeleted = false, CourseCode = "601-101-MQ", CourseCredits = 2.33, CourseName = "Français 1" }));
                troncCommun.Add(await _courseRepository.CreateAsync(new Course { IsDeleted = false, CourseCode = "601-102-MQ", CourseCredits = 2.33, CourseName = "Français 2" }));
                troncCommun.Add(await _courseRepository.CreateAsync(new Course { IsDeleted = false, CourseCode = "601-103-MQ", CourseCredits = 2.66, CourseName = "Français 3" }));
                troncCommun.Add(await _courseRepository.CreateAsync(new Course { IsDeleted = false, CourseCode = "601-EJJ-MV", CourseCredits = 2, CourseName = "Français 4" }));
                
                // Science nat
                scienceNat.Add(await _courseRepository.CreateAsync(new Course { IsDeleted = false, CourseCode = "203-SN1-RE", CourseCredits = 2.66, CourseName = "Mécanique" }));
                scienceNat.Add(await _courseRepository.CreateAsync(new Course { IsDeleted = false, CourseCode = "201-SN1-RE", CourseCredits = 1.66, CourseName = "Probabilités et Statistiques" }));
                scienceNat.Add(await _courseRepository.CreateAsync(new Course { IsDeleted = false, CourseCode = "202-SN1-RE", CourseCredits = 2.66, CourseName = "Chimie générale: La matière" }));
                scienceNat.Add(await _courseRepository.CreateAsync(new Course { IsDeleted = false, CourseCode = "101-SN1-RE", CourseCredits = 2, CourseName = "Biologie cellulaire" }));
                scienceNat.Add(await _courseRepository.CreateAsync(new Course { IsDeleted = false, CourseCode = "201-SNR-RE", CourseCredits = 2.66, CourseName = "Calcul différentiel" }));
                scienceNat.Add(await _courseRepository.CreateAsync(new Course { IsDeleted = false, CourseCode = "202-SN2-RE", CourseCredits = 2, CourseName = "Chimie des solutions" }));
                scienceNat.Add(await _courseRepository.CreateAsync(new Course { IsDeleted = false, CourseCode = "101-SNU-RE", CourseCredits = 2 , CourseName = "Anatomie et physiologie humaines" })); 
                scienceNat.Add(await _courseRepository.CreateAsync(new Course { IsDeleted = false, CourseCode = "203-SNC-RE", CourseCredits = 2, CourseName = "Astrophysique et notions d'ingénierie" }));
                scienceNat.Add(await _courseRepository.CreateAsync(new Course { IsDeleted = false, CourseCode = "101-SN2-RE", CourseCredits = 1.66, CourseName = "Écologie et évolution" })); 
                scienceNat.Add(await _courseRepository.CreateAsync(new Course { IsDeleted = false, CourseCode = "203-SN2-RE", CourseCredits = 2, CourseName = "Électricité et magnétisme" }));
                scienceNat.Add(await _courseRepository.CreateAsync(new Course { IsDeleted = false, CourseCode = "201-SN3-RE", CourseCredits = 2, CourseName = "Calcul Intégral" })); 
                scienceNat.Add(await _courseRepository.CreateAsync(new Course { IsDeleted = false, CourseCode = "201-SN4-RE", CourseCredits = 2, CourseName = "Algèbre linéaire et géometrie Vectorielle" }));
                scienceNat.Add(await _courseRepository.CreateAsync(new Course { IsDeleted = false, CourseCode = "203-NYC-05", CourseCredits = 2.66, CourseName = "Ondes et physique moderne" }));
                scienceNat.Add(await _courseRepository.CreateAsync(new Course { IsDeleted = false, CourseCode = "360-ESP-MV", CourseCredits = 2, CourseName = "Projet d'intégration en science de la nature" })); 
                scienceNat.Add(await _courseRepository.CreateAsync(new Course { IsDeleted = false, CourseCode = "201-SNC-RE", CourseCredits = 2, CourseName = "Calcul différentiel et intégral dans l'espace" }));
                scienceNat.Add(await _courseRepository.CreateAsync(new Course { IsDeleted = false, CourseCode = "202-SNU-RE", CourseCredits = 2, CourseName = "Chimie organique" }));
                
                // Histoire et civilisation
                histoire.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "300-111-MV",CourseCredits = 2 ,CourseName = "MTI : réussir en sciences humaines"}));
                histoire.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "350-114-MV",CourseCredits = 1 ,CourseName = "À la découverte de la psychologie"}));
                histoire.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "387-111-MV",CourseCredits = 1 ,CourseName = "L'imagination sociologique"}));
                histoire.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "385-111-MV",CourseCredits = 1 ,CourseName = "Politique et citoyenneté"}));
                histoire.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "320-111-MV",CourseCredits = 1 ,CourseName = "Regard géographique sur le monde"}));
                histoire.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "383-111-MV",CourseCredits = 1 ,CourseName = "Économie et société"}));
                histoire.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "330-211-MV",CourseCredits = 2 ,CourseName = "Histoire globale : le monde du XVe siècle à nos jours"}));
                histoire.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "300-222-RE",CourseCredits = 2 ,CourseName = "Recherche et méthodes qualitatives en sciences humaines"}));
                histoire.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "387-211-MV",CourseCredits = 1 ,CourseName = "Observation et enquête de terrain en sociologie"}));
                histoire.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "360-223-RE",CourseCredits = 2 ,CourseName = "Analyse quantitative des réalités humaines"}));
                histoire.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "350-314-MV",CourseCredits = 1 ,CourseName = "Psychologie du développement et du bien-être"}));   
                histoire.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "330-311-MV",CourseCredits = 2 ,CourseName = "Montréal, terrain d'histoire"}));
                histoire.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "300-411-MV",CourseCredits = 2 ,CourseName = "Projet de fin d'études en sciences humaines"}));
                histoire.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "330-170-MV",CourseCredits = 1 ,CourseName = "Des premiers royaume à la chute de l'empire Romain"}));
                histoire.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "340-170-MV",CourseCredits = 1 ,CourseName = "L'Homme et le sacré"}));
                histoire.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "385-170-MV",CourseCredits = 1 ,CourseName = "Pouvoir, démocratie et liberté"}));
                histoire.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "330-270-MV",CourseCredits = 1 ,CourseName = "Des grandes invasions aux grandes révolutions"}));
                histoire.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "340-270-MV",CourseCredits = 1 ,CourseName = "De la modernité à l'hypermodernité : La civilisation en marche"}));
                histoire.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "330-371-MV",CourseCredits = 1 ,CourseName = "De croire à savoir : L'évolution de la science"}));
                histoire.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "360-370-MV",CourseCredits = 1 ,CourseName = "De l'observation à la théorie"}));
                histoire.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "510-370-MV",CourseCredits = 2 ,CourseName = "L'atelier de l'artiste"}));
                histoire.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "340-370-MV",CourseCredits = 0.33 ,CourseName = "Dialogue philosophique"}));
                histoire.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "340-470-MV",CourseCredits = 2 ,CourseName = "L'histoire a-t-elle un sens?"}));
                histoire.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "330-470-MV",CourseCredits = 1 ,CourseName = "D'un continent à l'autre : les peuples qui ont fait le monde"}));
                histoire.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "601-470-MV",CourseCredits = 1 ,CourseName = "De l'épopée au roman"}));
                
                // Informatique
                informatique.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "420-110-MV",CourseCredits = 1 ,CourseName = "Documentation technique et profession"}));
                informatique.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "420-111-MV",CourseCredits = 3 ,CourseName = "Introduction à la programmation informatique"}));   
                informatique.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "420-112-MV",CourseCredits = 2 ,CourseName = "Création de sites web"}));
                informatique.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "420-113-MV",CourseCredits = 3 ,CourseName = "Systèmes d'exploitation"}));
                informatique.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "201-184-MV",CourseCredits = 2 ,CourseName = "Mathématiques de l'information"}));
                informatique.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "350-280-MV",CourseCredits = 2 ,CourseName = "Interactions humaines en informatique"}));
                informatique.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "420-210-MV",CourseCredits = 3 ,CourseName = "Programmation orientée objet"}));
                informatique.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "420-211-MV",CourseCredits = 3 ,CourseName = "Applications web"}));
                informatique.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "420-212-MV",CourseCredits = 2 ,CourseName = "Introduction aux bases de données"}));
                informatique.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "420-310-MV",CourseCredits = 1 ,CourseName = "Architecture de logiciel"}));
                informatique.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "420-311-MV",CourseCredits = 2 ,CourseName = "Structure de données"}));
                informatique.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "420-312-MV",CourseCredits = 3 ,CourseName = "Conception de réseaux informatiques"}));
                informatique.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "420-313-MV",CourseCredits = 2 ,CourseName = "Sécurité informatique"}));
                informatique.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "420-314-MV",CourseCredits = 2 ,CourseName = "Programmation de plateformes embarquées"}));   
                informatique.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "420-410-MV",CourseCredits = 3 ,CourseName = "Introduction aux plateformes IdO"}));
                informatique.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "420-411-MV",CourseCredits = 2 ,CourseName = "Interfaces humain-machine"}));
                informatique.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "420-412-MV",CourseCredits = 5 ,CourseName = "Projet - Développement d'une application web"}));   
                informatique.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "420-413-MV",CourseCredits = 2 ,CourseName = "Développement d'applications pour entreprise"}));   
                informatique.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "420-414-MV",CourseCredits = 1 ,CourseName = "Infonuagique"}));
                informatique.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "420-510-MV",CourseCredits = 2 ,CourseName = "Soutien informatique"}));
                informatique.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "420-511-MV",CourseCredits = 4 ,CourseName = "Développement de jeux vidéo"}));
                informatique.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "420-512-MV",CourseCredits = 3 ,CourseName = "Développement d'applications mobiles"}));
                informatique.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "420-513-MV",CourseCredits = 2 ,CourseName = "Piratage éthique"}));
                informatique.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "420-514-MV",CourseCredits = 4 ,CourseName = "Collecte et interprétation de données"}));
                informatique.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "420-515-MV",CourseCredits = 2 ,CourseName = "Maintenance de logiciel"}));
                informatique.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "420-610-MV",CourseCredits = 7 ,CourseName = "Stage d'intégration en entreprise"}));
                informatique.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "420-611-MV",CourseCredits = 5 ,CourseName = "Projet - Développement IdO"}));
                
                // Commercialisation de la mode
                commercialisationMode.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "571-1M1-MV",CourseCredits = 2 ,CourseName = "Métiers en commercialisation de la mode"}));
                commercialisationMode.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "571-1M2-MV",CourseCredits = 2 ,CourseName = "Marketing de la mode"}));
                commercialisationMode.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "571-1M3-MV",CourseCredits = 2 ,CourseName = "Portrait de l'industrie de la mode"}));
                commercialisationMode.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "571-1M5-MV",CourseCredits = 1 ,CourseName = "Matières et textiles"}));
                commercialisationMode.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "571-1M4-MV",CourseCredits = 1 ,CourseName = "Phénomène de la mode"}));
                commercialisationMode.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "571-2M1-MV",CourseCredits = 2 ,CourseName = "Consommer la mode"}));
                commercialisationMode.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "571-2M2-MV",CourseCredits = 2 ,CourseName = "Éléments du design"}));
                commercialisationMode.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "571-2M3-MV",CourseCredits = 2 ,CourseName = "Qualité des produits mode"}));
                commercialisationMode.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "571-2M4-MV",CourseCredits = 3 ,CourseName = "Mise en marché de la mode"}));
                commercialisationMode.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "571-2M5-MV",CourseCredits = 1 ,CourseName = "Stratégies de vente et de démarrage"}));
                commercialisationMode.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "383-3M2-MV",CourseCredits = 1 ,CourseName = "Environnement économique"}));
                commercialisationMode.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "571-3M3-MV",CourseCredits = 2 ,CourseName = "Achat de produits mode"}));
                commercialisationMode.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "571-3M4-MV",CourseCredits = 2 ,CourseName = "Styles et tendances"}));
                commercialisationMode.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "571-3M5-MV",CourseCredits = 2 ,CourseName = "Présentation visuelle mode"}));
                commercialisationMode.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "571-3M6-MV",CourseCredits = 2 ,CourseName = "Stratégies de communication mode"}));
                commercialisationMode.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "571-4M1-MV",CourseCredits = 2 ,CourseName = "Innovations commerciales en mode"}));
                commercialisationMode.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "571-4M2-MV",CourseCredits = 1 ,CourseName = "Droits des affaires des entreprises mode"}));       
                commercialisationMode.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "571-4M3-MV",CourseCredits = 2 ,CourseName = "Développement de programmes exclusifs mode"}));     
                commercialisationMode.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "571-4M4-MV",CourseCredits = 3 ,CourseName = "Activités de communication mode"}));
                commercialisationMode.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "571-4M6-MV",CourseCredits = 2 ,CourseName = "Développement de marchés mode"}));
                commercialisationMode.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "571-5M1-MV",CourseCredits = 1 ,CourseName = "Recherche commerciale mode"}));
                commercialisationMode.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "571-5M2-MV",CourseCredits = 2 ,CourseName = "Comptabilité d'une entreprise mode"}));
                commercialisationMode.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "571-5M3-MV",CourseCredits = 1 ,CourseName = "Gérer des équipes de travail en mode"}));
                commercialisationMode.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "571-5M4-MV",CourseCredits = 2 ,CourseName = "Gestion de l'assortiment de produits mode"}));      
                commercialisationMode.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "571-5M5-MV",CourseCredits = 2 ,CourseName = "Stylisme de mode"}));
                commercialisationMode.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "571-5M6-MV",CourseCredits = 2 ,CourseName = "Communication mode intégrée"}));
                commercialisationMode.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "571-5M8-MV",CourseCredits = 2 ,CourseName = "Parcours professionnel : objectifs et planification"}));
                commercialisationMode.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "571-6M1-MV",CourseCredits = 9 ,CourseName = "Stage d'intervention en commercialisation de la mode"}));
                commercialisationMode.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "571-6M2-MV",CourseCredits = 4 ,CourseName = "Projet d'intégration en commercialisation de la mode"}));
                commercialisationMode.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "571-6M3-MV",CourseCredits = 1 ,CourseName = "Analyse financière des entreprises mode"}));        
                commercialisationMode.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-6M4-MV",CourseCredits = 2 ,CourseName = "Espace commercial mode"}));
                                
                // design interieur
                designInterieur.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-1D4-MV",CourseCredits = 3 ,CourseName = "Couleur 1"}));
                designInterieur.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "520-1A1-MV",CourseCredits = 1 ,CourseName = "Courants artistiques et stylistiques 1"}));
                designInterieur.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-1D2-MV",CourseCredits = 2 ,CourseName = "Esquisse 1"}));
                designInterieur.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-1D5-MV",CourseCredits = 1 ,CourseName = "Matériaux I"}));
                designInterieur.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-1D1-MV",CourseCredits = 2 ,CourseName = "Introduction au design d'intérieur"}));
                designInterieur.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-1D3-MV",CourseCredits = 2 ,CourseName = "AutoCAD"}));
                designInterieur.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "510-2D5-MV",CourseCredits = 3 ,CourseName = "Matériaux II"}));
                designInterieur.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "510-2D2-MV",CourseCredits = 3 ,CourseName = "Esquisse II"}));
                designInterieur.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "520-2A1-MV",CourseCredits = 1 ,CourseName = "Courants artistiques et stylistiques 2"}));
                designInterieur.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-2D3-MV",CourseCredits = 3 ,CourseName = "SketchUP - conception 3D"}));
                designInterieur.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-2D4-MV",CourseCredits = 2 ,CourseName = "Couleur 2"}));
                designInterieur.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-2D0-MV",CourseCredits = 2 ,CourseName = "Projet d'habitat"}));
                designInterieur.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-3D3-MV",CourseCredits = 2 ,CourseName = "REVIT I"}));
                designInterieur.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-3D9-MV",CourseCredits = 2 ,CourseName = "Éléments d'architecture intérieure I"}));
                designInterieur.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-3D8-MV",CourseCredits = 2 ,CourseName = "Conception sur mesure I"}));
                designInterieur.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-3D0-MV",CourseCredits = 4 ,CourseName = "Projets d'hébergement public"}));
                designInterieur.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-3D5-MV",CourseCredits = 2 ,CourseName = "Matériaux III"}));
                designInterieur.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-4D3-MV",CourseCredits = 2 ,CourseName = "REVIT II"}));
                designInterieur.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-4D9-MV",CourseCredits = 2 ,CourseName = "Éléments d'architecture intérieure II"}));
                designInterieur.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-4D8-MV",CourseCredits = 2 ,CourseName = "Conception sur mesure II"}));
                designInterieur.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-4D0-MV",CourseCredits = 4 ,CourseName = "Projets d'aménagement de bureau"}));
                designInterieur.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-4D7-MV",CourseCredits = 2 ,CourseName = "Éclairage"}));
                designInterieur.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-4D5-MV",CourseCredits = 2 ,CourseName = "Matériaux IV"}));
                designInterieur.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-4D6-MV",CourseCredits = 2 ,CourseName = "Mobilier et produits spécifiés"}));
                designInterieur.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-5D2-MV",CourseCredits = 3 ,CourseName = "Présentation et traitement de l'image"}));
                designInterieur.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-5D9-MV",CourseCredits = 2 ,CourseName = "Éléments d'architecture intérieure III"}));
                designInterieur.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-5D8-MV",CourseCredits = 2 ,CourseName = "Conception sur mesure III"}));
                designInterieur.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-5D0-MV",CourseCredits = 5 ,CourseName = "Projets commerciaux"}));
                designInterieur.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-5D3-MV",CourseCredits = 2 ,CourseName = "REVIT III"}));
                designInterieur.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-6A1-MV",CourseCredits = 1 ,CourseName = "Projets actuels en design d'intérieur"}));
                designInterieur.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-6D1-MV",CourseCredits = 2 ,CourseName = "Pratique professionnelle"}));
                designInterieur.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-6D0-MV",CourseCredits = 7 ,CourseName = "Projet final"}));
                designInterieur.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-6D3-MV",CourseCredits = 3 ,CourseName = "Plans d'exécution"}));

                // Graphisme 
                graphisme.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "510-1G0-MV",CourseCredits = 2 ,CourseName = "Techniques de dessin"}));
                graphisme.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "510-1G1-MV",CourseCredits = 2 ,CourseName = "Couleur et sérigraphie"}));
                graphisme.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "520-1G1-MV",CourseCredits = 1 ,CourseName = "Histoire des arts visuels"}));
                graphisme.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-1G0-MV",CourseCredits = 2 ,CourseName = "Graphisme et typographie"}));
                graphisme.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-1G1-MV",CourseCredits = 3 ,CourseName = "Graphisme vectoriel 1"}));
                graphisme.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-1G2-MV",CourseCredits = 3 ,CourseName = "Graphisme matriciel 1"}));
                graphisme.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "510-2G1-MV",CourseCredits = 3 ,CourseName = "Photographie et sérigraphie"}));
                graphisme.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "520-2G1-MV",CourseCredits = 1 ,CourseName = "Histoire du graphisme"}));
                graphisme.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-2G0-MV",CourseCredits = 2 ,CourseName = "Idéation"}));
                graphisme.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-2G1-MV",CourseCredits = 3 ,CourseName = "Graphisme vectoriel 2 et imprimés"}));
                graphisme.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-2G2-MV",CourseCredits = 3 ,CourseName = "Graphisme matriciel 2 et interfaces"}));
                graphisme.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-2G3-MV",CourseCredits = 2 ,CourseName = "Prépresse"}));
                graphisme.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-3G0-MV",CourseCredits = 2 ,CourseName = "Icônes et pictogrammes"}));
                graphisme.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-3G1-MV",CourseCredits = 2 ,CourseName = "Photographie et studio"}));
                graphisme.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-3G3-MV",CourseCredits = 2 ,CourseName = "Gestion de projet"}));
                graphisme.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-3G4-MV",CourseCredits = 3 ,CourseName = "Publicité 1"}));
                graphisme.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-3G5-MV",CourseCredits = 2 ,CourseName = "Mises en pages multimédia et imprimés"}));
                graphisme.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-3G6-MV",CourseCredits = 2 ,CourseName = "Illustration 1"}));
                graphisme.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "510-4G9-MV",CourseCredits = 2 ,CourseName = "Animation et image cinétique"}));
                graphisme.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-4G1-MV",CourseCredits = 3 ,CourseName = "Production d'imprimés"}));
                graphisme.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-4G5-MV",CourseCredits = 2 ,CourseName = "Production multimédia"}));
                graphisme.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-4G6-MV",CourseCredits = 2 ,CourseName = "Illustration 2"}));
                graphisme.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-4G7-MV",CourseCredits = 3 ,CourseName = "Packaging 1"}));
                graphisme.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-4G8-MV",CourseCredits = 3 ,CourseName = "Identité visuelle 1"}));
                graphisme.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-5G0-MV",CourseCredits = 3 ,CourseName = "Design multimédia"}));
                graphisme.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-5G1-MV",CourseCredits = 3 ,CourseName = "Design corporatif 1"}));
                graphisme.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-5G7-MV",CourseCredits = 3 ,CourseName = "Packaging 2"}));
                graphisme.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-5G8-MV",CourseCredits = 3 ,CourseName = "Identité visuelle 2"}));
                graphisme.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-5G9-MV",CourseCredits = 3 ,CourseName = "Design cinétique"}));
                graphisme.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-6G0-MV",CourseCredits = 4 ,CourseName = "Laboratoire de création"}));
                graphisme.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-6G1-MV",CourseCredits = 5 ,CourseName = "Design corporatif 2"}));
                graphisme.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-6G2-MV",CourseCredits = 3 ,CourseName = "Stage en entreprise"}));
                graphisme.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-6G3-MV",CourseCredits = 5 ,CourseName = "Promotion professionnelle"}));
                graphisme.Add(await _courseRepository.CreateAsync(new Course{IsDeleted = false,CourseCode = "570-6G4-MV",CourseCredits = 4 ,CourseName = "Publicité 2"}));
                
                // ==== PROGRAMS ====
                var programs = await _programRepository.GetAllAsync();
                if (!programs.Any())
                {
                    scienceNatProgram = await _programRepository.CreateAsync(new PAT.Models.Entities.Program { ProgramCode = "200.B1", ProgramType = ProgramTypeEnum.DecPreuniversitaire, Courses = scienceNat, ProgramName = "Science de la Nature", IsDeleted = false });
                    infoProgram = await _programRepository.CreateAsync(new PAT.Models.Entities.Program { ProgramCode = "420.B0", ProgramType = ProgramTypeEnum.DecTechnique, Courses = informatique, ProgramName = "Informatique", IsDeleted = false });
                    histoireProgram = await _programRepository.CreateAsync(new PAT.Models.Entities.Program { ProgramCode = "700.B0", ProgramType = ProgramTypeEnum.DecPreuniversitaire, Courses = histoire, ProgramName = "Histoire et Civilisation", IsDeleted = false });
                    graphismeProgram = await _programRepository.CreateAsync(new PAT.Models.Entities.Program { ProgramCode = "570.G0", ProgramType = ProgramTypeEnum.DecTechnique, Courses = graphisme, ProgramName = "Graphisme", IsDeleted = false });
                    designInterieurProgram = await _programRepository.CreateAsync(new PAT.Models.Entities.Program { ProgramCode = "570.E0", ProgramType = ProgramTypeEnum.DecTechnique, Courses = designInterieur, ProgramName = "Design d'intérieur", IsDeleted = false });
                    commercialisationModeProgram = await _programRepository.CreateAsync(new PAT.Models.Entities.Program { ProgramCode = "571.C0", ProgramType = ProgramTypeEnum.DecTechnique, Courses = graphisme, ProgramName = "Commercialisation de la mode", IsDeleted = false });
                }
            }

            // ==== ADMINS ====
            var admins = await _adminRepository.GetAllAsync();
            if (!admins.Any())
            {
                await _adminRepository.CreateAsync(new Admin { Email = "raphaelpaquin19@gmail.com", IsDeleted = false, FirstName = "Raph", LastName = "Paquin", Phone = "1112223333" });
                await _adminRepository.CreateAsync(new Admin { Email = "jennalee.lecavalier@gmail.com", IsDeleted = false, FirstName = "Jenalee", LastName = "Lecavalier", Phone = "1919995555" });
                await _adminRepository.CreateAsync(new Admin { Email = "Cindy.bragdon@gmail.com", IsDeleted = false, FirstName = "Cindy", LastName = "Bragdon", Phone = "0001119999" });
                await _adminRepository.CreateAsync(new Admin { Email = "hasilon88@gmail.com", IsDeleted = false, FirstName = "Harjot", LastName = "Dhillon Singh", Phone = "9991112222" });
            }

            // ==== TEACHERS ====
            var teachers = await _teacherRepository.GetAllAsync();
            if (!teachers.Any())
            {


                if (infoProgram != null)
                    await _teacherRepository.CreateAsync(new Teacher
                        { IsDeleted = false, Email = "reda.hamza@gmail.com", Program = infoProgram, LastName = "Hamza", FirstName = "Réda", Phone = "1115552222", EmployeeNumber = "55544"});
                
                if (histoireProgram != null)
                    await _teacherRepository.CreateAsync(new Teacher
                        { IsDeleted = false, Email = "johnDoe@gmail.com", Program = histoireProgram, LastName = "Doe", FirstName = "John", Phone = "9992225555", EmployeeNumber = "22444"});

                if (scienceNatProgram != null)
                    await _teacherRepository.CreateAsync(new Teacher
                        { IsDeleted = false, Email = "Barrington@gmail.com", Program = scienceNatProgram, LastName = "Barrington", FirstName = "Vaughn", Phone = "51455555555", EmployeeNumber = "17191"});

                if (commercialisationModeProgram != null)
                    await _teacherRepository.CreateAsync(new Teacher
                        { IsDeleted = false, Email = "mimi@gmail.com", Program = commercialisationModeProgram, LastName = "Jane", FirstName = "Mizuki", Phone = "5144443333", EmployeeNumber = "22514"});

                if (graphismeProgram != null)
                    await _teacherRepository.CreateAsync(new Teacher
                        { IsDeleted = false, Email = "antoine@gmail.com", Program = graphismeProgram, LastName = "Doom", FirstName = "Antoine", Phone = "1115552222", EmployeeNumber = "12583"});

                if (designInterieurProgram != null)
                    await _teacherRepository.CreateAsync(new Teacher
                        { IsDeleted = false, Email = "lynda.teacher@gmail.com", Program = designInterieurProgram, LastName = "Teacher", FirstName = "Lynda", Phone = "8921115555", EmployeeNumber = "13124"});
            }
            
            // ==== STUDENT ====
            var students = await _studentRepository.GetAllAsync();
            if (!students.Any())
            {
                if (!enumerable.Any())
                {
                    throw new Exception("error creating student types in data loader : App.xaml.cs");
                }
                
                for (int i = 0; i < 15; i++)
                {
                    var daNumber = GenerateRandomNumber(7);
                    await _studentRepository.CreateAsync(new Student { Email = $"{daNumber}@collegemv.qc.ca", IsDeleted = false, EmployeeNumber = "", GlobalAverage = GenerateRandomAverage(),                       StudentRoleTypes = new[] { enumerable.Single() }, RScore = GenerateRandomRScore(), DANumber = daNumber, Phone = GenerateRandomPhoneNumber(), FirstName = GenerateRandomFirstName(), LastName = GenerateRandomLastName() });
                }
            }

        }
        
        float GenerateRandomAverage()
        {
            Random random = new Random();
            return random.Next(50, 100); // Generates a random average between 50 and 100
        }

        int GenerateRandomRScore()
        {
            Random random = new Random();
            return random.Next(10, 40); // Generates a random R-Score between 10 and 40
        }

        string GenerateRandomPhoneNumber()
        {
            Random random = new Random();
            return $"{random.Next(100, 999)}{random.Next(100, 999)}{random.Next(1000, 9999)}"; // Generates a random phone number
        }

        string GenerateRandomFirstName()
        {
            string[] firstNames = { "John", "Alice", "Michael", "Emily", "Daniel", "Sophia", "William", "Olivia", "James", "Emma" };
            Random random = new Random();
            return firstNames[random.Next(0, firstNames.Length)];
        }

        string GenerateRandomLastName()
        {
            string[] lastNames = { "Smith", "Johnson", "Williams", "Brown", "Jones", "Garcia", "Miller", "Davis", "Rodriguez", "Martinez" };
            Random random = new Random();
            return lastNames[random.Next(0, lastNames.Length)];
        }
        
        string GenerateRandomNumber(int length)
        {
            Random random = new Random();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                sb.Append(random.Next(10));
            }
            return sb.ToString();
        }
    }
}