import './App.scss';
import { RandomImage } from './components/randomImage/randomImage';
import { Board} from "./components/board/board";
import React from 'react';

const imageList: string[] = [
  'https://media.nature.com/lw800/magazine-assets/d41586-020-01430-5/d41586-020-01430-5_17977552.jpg',
  'https://blog.consumerguide.com/wp-content/uploads/sites/2/2018/04/Honda-N-Box.png',
  'https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/paulo-bent-ply-leather-chair-o-1582926567.jpg',
  'https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/aylin-rug-1582929236.jpg',
  'https://www.sportsnet.ca/wp-content/uploads/2020/08/Lionel-Messi-Barcelona-Champions-League-1040x572.jpg',
  'https://mk0mexiconewsdam2uje.kinstacdn.com/wp-content/uploads/2015/12/quetzal-flying-mejor.jpg'
];

const playersItems: string[] = [
  'https://media.nature.com/lw800/magazine-assets/d41586-020-01430-5/d41586-020-01430-5_17977552.jpg',
  'https://blog.consumerguide.com/wp-content/uploads/sites/2/2018/04/Honda-N-Box.png',
  'https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/paulo-bent-ply-leather-chair-o-1582926567.jpg',
  'https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/aylin-rug-1582929236.jpg'
];


function App() {
  return (
    <div className='App'>
      <header className='App-header'>
        Lingo
      </header>

      <RandomImage allItems={imageList} playerBoardItems={playersItems}></RandomImage>
      <Board boardItems={playersItems}></Board>
    </div>
  );
}

export default App;
