using Tanks.Complete;

public class TeamManager
{
    private const int allyId = 0;
    private const int enemyId = 1;
    private int tanksPerTeam = 1;

    private TankMovement[][] tankMovements;
    private int currentAllies = 1;
    private int currentEnemies = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    public int getTeamWin()
    {
        // return id of the team or -1 if no team has won
        return -1;
    }
    public class Builder
    {
        private readonly TeamManager _teamManager = new TeamManager();

        public Builder SetTanksPerTeam(int tanksPerTeam)
        {
            _teamManager.tanksPerTeam = tanksPerTeam;

            // Initialize jagged array
            _teamManager.tankMovements = new TankMovement[2][];
            _teamManager.tankMovements[allyId] = new TankMovement[tanksPerTeam];
            _teamManager.tankMovements[enemyId] = new TankMovement[tanksPerTeam];

            for (int i = 0; i < tanksPerTeam; i++)
            {
                _teamManager.tankMovements[allyId][i] = new TankMovement();
                _teamManager.tankMovements[enemyId][i] = new TankMovement();
            }

            return this;
        }

        public TeamManager Build()
        {
            return _teamManager;
        }
    }
}


