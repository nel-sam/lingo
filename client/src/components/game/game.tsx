import React, { Component } from "react";
import './game.scss';
import { RandomImage } from "../randomImage/randomImage";
import { LingoCell, LingoGame } from "../../models/interfaces";
import { BoardService } from "../../services/board.service";
import { Board } from "../board/board";


interface IProps {
}

interface GameState {
  game?: LingoGame;
}


export class Game extends Component<IProps, GameState> {
  private boardService: BoardService = new BoardService();

  constructor(props: IProps) {
    super(props);

    this.state = {
      game: undefined
    };
  }

  async componentDidMount() {
    this.setState({
      game: await this.boardService.getGame(),
    });
  }
  
  render() {
    return <div className='game'>
      <header className='game-header'>
        Lingo
      </header>
      {this.state?.game?.players && this.state.game?.players.map(function (player) {
        return (<div>
          <Board playerInfo={player}></Board>
        </div>);
      })}
    </div>
  }
}