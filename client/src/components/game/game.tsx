import React, { Component } from "react";
import './game.scss';
import { RandomImage } from "../randomImage/randomImage";
import { LingoCell, LingoBoard } from "../../models/interfaces";
import { BoardService } from "../../services/board.service";
import { Board } from "../board/board";

const playersItems: LingoCell[] = [
  { id: 'dog', url: 'https://media.nature.com/lw800/magazine-assets/d41586-020-01430-5/d41586-020-01430-5_17977552.jpg' } as LingoCell,
  { id: 'car', url: 'https://blog.consumerguide.com/wp-content/uploads/sites/2/2018/04/Honda-N-Box.png' } as LingoCell,
  { id: 'chr', url: 'https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/paulo-bent-ply-leather-chair-o-1582926567.jpg' } as LingoCell,
  { id: 'ali', url: 'https://static.independent.co.uk/s3fs-public/thumbnails/image/2015/10/07/23/web-ali-g-getty.jpg?width=1200' } as LingoCell,
  { id: 'mss', url: 'https://static01.nyt.com/images/2020/09/25/sports/25soccer-nationalWEB1/merlin_177451008_91c7b66d-3c8a-4963-896e-54280f374b6d-articleLarge.jpg?quality=75&auto=webp&disable=upscale' } as LingoCell,
  { id: 'leh', url: 'https://cdn.theathletic.com/app/uploads/2019/09/06104502/GettyImages-1165481703-e1567781166557-1024x684.jpg' } as LingoCell,
  { id: 'red', url: 'https://cdn.vox-cdn.com/thumbor/1mxkqqttp-h6NTQ9fF6wbcXMcdg=/12x0:4907x3263/1400x1050/filters:focal(12x0:4907x3263):format(jpeg)/cdn.vox-cdn.com/uploads/chorus_image/image/49388585/16071828377_85109fdee4_o.0.0.jpg' } as LingoCell,
  { id: 'mrj', url: 'https://post.healthline.com/wp-content/uploads/2019/04/Weed_Orange_1200x628-facebook.jpg' } as LingoCell,
  { id: 'nsx', url: 'https://www.motortrend.com/uploads/sites/5/2020/01/2020-Acura-NSX-front-three-quarters.jpg' } as LingoCell,
];

interface IProps {
}

interface GameState {
  board?: LingoBoard;
}

export class Game extends Component<IProps, GameState> {
  private boardService: BoardService = new BoardService();

  constructor(props: IProps) {
    super(props);

    this.state = {
      board: undefined
    };
  }

  async componentDidMount() {
    this.setState({
      board: await this.boardService.getBoard()
    });
  }

  render() {
    return <div className='game'>
      <header className='game-header'>
        Lingo
      </header>

      {this.state?.board?.cells &&
        <div>
          <RandomImage allItems={this.state.board.cells} playerBoardItems={playersItems}></RandomImage>
          <Board boardItems={playersItems}></Board>
        </div>
      }
    </div>
  }
}