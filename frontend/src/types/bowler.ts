export interface Teams {
    // Define the properties of your Teams model here.
    // For example:
    teamID?: number;
    teamName?: string;
    // Add additional properties as needed.
  }
  
  export interface Bowlers {
    bowlerID: number; // Primary key
    bowlerLastName?: string; // Max length 50
    bowlerFirstName?: string; // Max length 50
    bowlerMiddleInit?: string; // Max length 1
    bowlerAddress?: string; // Max length 50
    bowlerCity?: string; // Max length 50
    bowlerState?: string; // Max length 2
    bowlerZip?: string; // Max length 10
    bowlerPhoneNumber?: string; // Max length 14
    teamID?: number;
    team?: Teams;
  }
  