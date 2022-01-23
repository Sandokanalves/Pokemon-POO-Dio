namespace Pokemon_POO.src
{
    public abstract class Pokemon
    {
        private string Name;
        private string Abilities;

        private string Category;
         
         private Boolean Evolutions; 

         private string Type;


         public Pokemon (string name,string abilities, string category, Boolean evolutions, string type) 
         {
             this.Name = name;
             this.Abilities = abilities;
             this.Category = category;
            this.Evolutions = evolutions;
            this.Type = type;
         }
      

        public string PokebollStart(){
            Console.WriteLine("Iniciando Jogada com o Pokemon: \n " + "TIPO: "+ this.Type +"\n "+ "NOME: " + this.Name + "\n "+ "HABILIDADES: "+ this.Abilities +"\n "+ "CATEGORIA: " + this.Category); 
            return "";
       
        }

        public virtual string Attack (){
            return this.Name + "Atacou";
        }

    
      public override string ToString(){
          return this.Name + this.Abilities + this.Category + this.Evolutions;
      }
    }
}