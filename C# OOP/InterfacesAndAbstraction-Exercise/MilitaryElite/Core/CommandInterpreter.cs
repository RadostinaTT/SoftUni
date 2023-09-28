namespace MilitaryElite.Core
{
    using Contracts;
    using Enums;
    using Models;
    using System;
    using System.Collections.Generic;

    public class CommandInterpreter : ICommandInterpreter
    {
        private Dictionary<int, ISoldier> soldiers;
        public CommandInterpreter()
        {
            this.soldiers = new Dictionary<int, ISoldier>();
        }
        
        public string Read(string[] args)
        {
            string soldierType = args[0];
            int id = int.Parse(args[1]);
            string firstName = args[2];
            string lastName = args[3];

            ISoldier soldier = null;

            if (soldierType == "Private")
            {
                decimal salary = decimal.Parse(args[4]);
                soldier = new Private(id, firstName, lastName, salary);
                this.soldiers.Add(id, soldier);

                return soldier.ToString();
            }
            else if(soldierType == "LieutenantGeneral")
            {
                decimal salary = decimal.Parse(args[4]);
                var privates = new Dictionary<int, IPrivate>();

                for (int i = 5; i < args.Length; i++)
                {
                    int soldierId = int.Parse(args[i]);
                    var currentSoldier = (Private)soldiers[soldierId];
                    privates.Add(soldierId, currentSoldier);
                }
                soldier = new LeutenantGeneral(id, firstName, lastName, salary, privates);
            }
            else if (soldierType == "Engineer")
            {
                decimal salary = decimal.Parse(args[4]);
                var privates = new Dictionary<int, IPrivate>();
                bool IsValidCorps = Enum.TryParse<Corps>(args[5], out Corps corps);

                if (!IsValidCorps)
                {
                    throw new Exception("Invalid copr");
                }

                ICollection<IRepair> repairs = new List<IRepair>();

                for (int i = 6; i < args.Length; i += 2)
                {
                    string currentPartName = args[i];
                    int currentHours = int.Parse(args[i + 1]);
                    IRepair repair = new Repair(currentPartName, currentHours);
                    repairs.Add(repair);
                }

                soldier = new Engineer(id, firstName, lastName, salary, corps, repairs);
            }
            else if (soldierType == "Commando")
            {
                decimal salary = decimal.Parse(args[4]);
                var privates = new Dictionary<int, IPrivate>();
                bool IsValidCorps = Enum.TryParse<Corps>(args[5], out Corps corps);

                if (!IsValidCorps)
                {
                    throw new Exception("Invalid copr");
                }

                ICollection<IMission> missions = new List<IMission>();

                for (int i = 6; i < args.Length; i += 2)
                {
                    string currentMissionName = args[i];
                    string missionState = args[i + 1];

                    bool IsValidState = Enum.TryParse<State>(missionState, out State stateResult);

                    if (!IsValidState)
                    {
                        continue;
                    }

                    IMission mission = new Mission(currentMissionName, stateResult);
                    missions.Add(mission);
                }

                soldier = new Commando(id, firstName, lastName, salary, corps, missions);
            }
            else if (soldierType == "Spy")
            {
                int codeNumber = int.Parse(args[4]);
                soldier = new Spy(id, firstName, lastName, codeNumber);
            }
            soldiers.Add(id, soldier);

            return soldier.ToString();
        }
    }
}
