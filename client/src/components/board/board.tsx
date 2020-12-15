import React, { Component } from "react";
import './board.scss';


export interface IBoardProps {
  txt?: string;
}


export class Board extends Component<IBoardProps, {}> {
  state = {
       images: [
      'https://media.nature.com/lw800/magazine-assets/d41586-020-01430-5/d41586-020-01430-5_17977552.jpg',
      'https://blog.consumerguide.com/wp-content/uploads/sites/2/2018/04/Honda-N-Box.png',
      'https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/paulo-bent-ply-leather-chair-o-1582926567.jpg',
      'https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/aylin-rug-1582929236.jpg']
  };

  render() {
    return <div className='container'>
    {
      this.state.images.map(function (value) {
        return <img alt="" className="cell-img" src={value}/>;
      })
    };
  </div>
  }
}
