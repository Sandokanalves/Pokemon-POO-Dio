namespace Pokemon_POO.src
{
    public class TypeFire : Pokemon
    {
        public TypeFire(string name, string abilities, string category, bool evolutions, string type) : base(name, abilities, category, evolutions, type)
        {
        }
        
        public override string Attack()
        {
            Console.WriteLine("Digite o Nome do Ataque conforme a Lista: ");
            Console.WriteLine( " - Ember \n - Fire Blast\n - Fire Punch\n - Fire Spin\n - Flamethrower");
            var name = Console.ReadLine();

            switch (name)
            { 
                case "Ember" : 
                   Console.WriteLine("O alvo é atacado com pequenas chamas. Isso também pode deixar o alvo queimado.");
                    break;
                case "Fire Blast": 
                     Console.WriteLine("O alvo é atacado com uma explosão intensa de fogo que tudo consome. Isso também pode deixar o alvo queimado");
                    break;
                case "Fire Punch": 
                    Console.WriteLine("O alvo é perfurado com um punho de fogo. Isso também pode deixar o alvo queimado.");
                    break;
                case "Fire Spin": 
                     Console.WriteLine("O alvo fica preso em um vórtice de fogo feroz que dura de quatro a cinco turnos.");
                    break;
                case "Flamethrower": 
                     Console.WriteLine("O alvo é queimado com uma intensa explosão de fogo. Isso também pode deixar o alvo queimado..");
                    break;
                default:
                      Console.WriteLine("Digite o nome do ataque da lista");
                      Attack();
                      break;
            }
                 return "";
           
        }

    }
}