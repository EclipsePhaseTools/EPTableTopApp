namespace EPTabletopApp.Models
{
    public class RollResult
    {
        public int Result { get; set; }
        public int OriginalTargetNumber { get; set; }
        public int ModifiedTargetNumber { get; set; }
        public string Reason { get; set; }
        public string CharacterName { get; set; }
        public bool Success { get; set; }
        public int SuperiorSuccesses { get; set; }
        public int SuperiorFailures { get; set; }
        public string Notes { get; set; } = "";
        public bool Critical { get; set; }
        public string Text { get; set; } = "";

        public static RollResult PerformRoll(Character character, int roll, int target, string reason, int die)
        {
            var result = new RollResult();

            result.Reason = reason;
            result.OriginalTargetNumber = target;
            result.Result = roll;
            result.CharacterName = character.Name;

            if (character.Traumas > 0)
            {
                var penalty = character.Traumas * 10;
                target -= penalty;
                result.Notes += $"Penalty from {result.CharacterName}'s {character.Traumas} Traumas";
            }
            if (character.Morph.Wounds > 0)
            {
                var penalty = character.Traumas * 10;
                target -= penalty;
                result.Notes += $"Penalty from {result.CharacterName}'s {character.Morph.Wounds} Traumas";
            }


            result.ModifiedTargetNumber = target;
            result.Success = roll <= target;

            if (result.Success)
            {
                if (roll >= 66)
                    result.SuperiorSuccesses++;
                if (roll >= 33)
                    result.SuperiorSuccesses++;
            }
            else
            {
                if (roll <= 33)
                    result.SuperiorFailures++;
                if (roll <= 66)
                    result.SuperiorFailures++;
            }

            if (roll == 0 || roll % 11 == 0)
            {
                result.Critical = true;
            }
            result.Text += result.Critical ? "Critical " : "";
            result.Text += result.Success ? "Success" : "Failure";
            if (result.SuperiorSuccesses > 0)
            {
                result.Text += "";
            }
            result.Text += result.Critical ? "!" : "";

            return result;
        }



        public string WebHookString()
        {
            string sup_text = "";

            if (SuperiorSuccesses > 0)
            {
                sup_text = "Choose **" + SuperiorSuccesses + "** :\n";
                sup_text += "**Quantity** : The test consumes fewer materials or produces more results\n";
                sup_text += "**Quality** : The work is more exact \n";
                sup_text += "**Detail** : You acquire information that is much more in-depth or nuanced\n";
                sup_text += "**Time (task actions only)** : The action takes a 25% less time.\n";
                sup_text += "**Covertness ** : The action is less obvious or draws less attention (+/− 10 as appropriate).\n";
                sup_text += "**Damage ** : Inflict +1d6 damage\n";
            }
            if (SuperiorFailures > 0)
            {

                sup_text = "Choose **" + SuperiorFailures + "** :\n";
                sup_text += "**Quantity** : The test consumes more materials or produces fewer results\n";
                sup_text += "**Quality** : The work is more sloppy\n";
                sup_text += "**Detail** : You acquire false information\n";
                sup_text += "**Time (task actions only)** : The action takes a 25% more time.\n";
                sup_text += "**Covertness ** : The action is more obvious or draws more attention (+/− 10 as appropriate).\n";
            }

            return sup_text;
        }
    }
}
