export interface LingoCell {
  id: string;
  url: string;
}

export interface LingoBoard{
  cells: LingoCell[];
}

export interface LingoPlayer{
  firstName: string; 
  lastName: string; 
  board: LingoBoard;
  key: string;
}

export interface LingoGame{
  key: string;
  players: LingoPlayer[];
}