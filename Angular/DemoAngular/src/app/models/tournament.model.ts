export interface TournamentModel {
    id: string;
    name: string;
    location: string|null;
    minPlayers: number;
    maxPlayers: number;
    eloMin: number|null;
    eloMax: number|null;
    categories: string[];
    womenOnly: boolean;
    endOfRegistrationDate: string;
    count: number;
    canRegister: boolean;
    isRegistered: boolean;
    status: string;
    currentRound: number;
}