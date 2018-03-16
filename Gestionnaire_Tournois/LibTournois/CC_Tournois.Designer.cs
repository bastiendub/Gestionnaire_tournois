namespace LibTournois
{
    partial class CC_Tournois
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        public bool TestConnexion(string unNom, string unMdp)
        {
            bool res = false;


            adapteurUtilisateur.FillByConnexion(DS_Tournois.UTILISATEUR, unNom, unMdp);
            if(DS_Tournois.UTILISATEUR.Rows[0]!= null)
            {
                res = true;
            }

            return res;
        }
        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.adapteurEquipe = new LibTournois.DS_TournoisTableAdapters.EQUIPETableAdapter();
            this.adapteurMatch = new LibTournois.DS_TournoisTableAdapters.MATCHTableAdapter();
            this.adapteurParticiper = new LibTournois.DS_TournoisTableAdapters.PARTICIPERTableAdapter();
            this.adapteurTournois = new LibTournois.DS_TournoisTableAdapters.TOURNOISTableAdapter();
            this.adapteurUtilisateur = new LibTournois.DS_TournoisTableAdapters.UTILISATEURTableAdapter();
            this.DS_Tournois = new LibTournois.DS_Tournois();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Tournois)).BeginInit();
            // 
            // adapteurEquipe
            // 
            this.adapteurEquipe.ClearBeforeFill = true;
            // 
            // adapteurMatch
            // 
            this.adapteurMatch.ClearBeforeFill = true;
            // 
            // adapteurParticiper
            // 
            this.adapteurParticiper.ClearBeforeFill = true;
            // 
            // adapteurTournois
            // 
            this.adapteurTournois.ClearBeforeFill = true;
            // 
            // adapteurUtilisateur
            // 
            this.adapteurUtilisateur.ClearBeforeFill = true;
            // 
            // DS_Tournois
            // 
            this.DS_Tournois.DataSetName = "DS_Tournois";
            this.DS_Tournois.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            ((System.ComponentModel.ISupportInitialize)(this.DS_Tournois)).EndInit();

        }

        #endregion

        private DS_TournoisTableAdapters.EQUIPETableAdapter adapteurEquipe;
        private DS_TournoisTableAdapters.MATCHTableAdapter adapteurMatch;
        private DS_TournoisTableAdapters.PARTICIPERTableAdapter adapteurParticiper;
        private DS_TournoisTableAdapters.TOURNOISTableAdapter adapteurTournois;
        private DS_TournoisTableAdapters.UTILISATEURTableAdapter adapteurUtilisateur;
        private DS_Tournois DS_Tournois;
    }

    
}
