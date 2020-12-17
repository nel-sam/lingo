import React, { Component } from "react";
import './game.scss';
import { RandomImage } from "../randomImage/randomImage";
import { Board } from "../board/board";
import { LingoCell } from "../../models/interfaces";

const imageList: LingoCell[] = [
  { Id: 'dog', Url: 'https://media.nature.com/lw800/magazine-assets/d41586-020-01430-5/d41586-020-01430-5_17977552.jpg'} as LingoCell,
  { Id: 'car', Url: 'https://blog.consumerguide.com/wp-content/uploads/sites/2/2018/04/Honda-N-Box.png'} as LingoCell,
  { Id: 'chr', Url: 'https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/paulo-bent-ply-leather-chair-o-1582926567.jpg'} as LingoCell,
  { Id: 'rug', Url: 'https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/aylin-rug-1582929236.jpg'} as LingoCell,
  { Id: 'msi', Url: 'https://www.sportsnet.ca/wp-content/uploads/2020/08/Lionel-Messi-Barcelona-Champions-League-1040x572.jpg'} as LingoCell,
  { Id: 'qzt', Url: 'https://mk0mexiconewsdam2uje.kinstacdn.com/wp-content/uploads/2015/12/quetzal-flying-mejor.jpg'} as LingoCell,
];

const playersItems: LingoCell[] = [
  { Id: 'dog', Url: 'https://media.nature.com/lw800/magazine-assets/d41586-020-01430-5/d41586-020-01430-5_17977552.jpg'} as LingoCell,
  { Id: 'car', Url: 'https://blog.consumerguide.com/wp-content/uploads/sites/2/2018/04/Honda-N-Box.png'} as LingoCell,
  { Id: 'chr', Url: 'https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/paulo-bent-ply-leather-chair-o-1582926567.jpg'} as LingoCell,
  { Id: 'rug', Url: 'https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/aylin-rug-1582929236.jpg'} as LingoCell,
];

export class Game extends Component {
  render() {
    return <div className='App'>
      <header className='App-header'>
        Lingo
      </header>

      <RandomImage allItems={imageList} playerBoardItems={playersItems}></RandomImage>
      <Board boardItems={playersItems}></Board>
    </div>
  }
}