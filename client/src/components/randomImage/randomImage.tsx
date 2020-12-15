import React, { Component } from "react";
import {Board} from "../board/board";

export interface IBoardProps {
  txt?: string;
}

export class RandomImage extends Component<IBoardProps, {}> {
  private images: string[] = [
    'https://media.nature.com/lw800/magazine-assets/d41586-020-01430-5/d41586-020-01430-5_17977552.jpg',
    'https://blog.consumerguide.com/wp-content/uploads/sites/2/2018/04/Honda-N-Box.png',
    'https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/paulo-bent-ply-leather-chair-o-1582926567.jpg',
    'https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/aylin-rug-1582929236.jpg',
    'https://www.sportsnet.ca/wp-content/uploads/2020/08/Lionel-Messi-Barcelona-Champions-League-1040x572.jpg',
    'https://mk0mexiconewsdam2uje.kinstacdn.com/wp-content/uploads/2015/12/quetzal-flying-mejor.jpg'
  ];

  private images2: string[] = [
    'https://media.nature.com/lw800/magazine-assets/d41586-020-01430-5/d41586-020-01430-5_17977552.jpg',
    'https://blog.consumerguide.com/wp-content/uploads/sites/2/2018/04/Honda-N-Box.png',
    'https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/paulo-bent-ply-leather-chair-o-1582926567.jpg',
    'https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/aylin-rug-1582929236.jpg'
  ];

  
  bingoPoints = 0;
  status="";

  state = {
      images: "",
      bingoPoints: 0,
      status: ""
  };

  handleClick = () => {
      var value = Math.floor(Math.random() * Math.floor(this.images.length));
      for (var i= 0; i< this.images2.length; i++){
        if(this.images[value] === this.images2[i]){
            this.bingoPoints += 1;
            this.images2.splice(value,1);
        } 
      } 
      if(!this.images2.length){
          this.status = "winner";
      }
      this.setState({
        images: this.images[value],
        bingoPoints: this.bingoPoints,
        status: this.status
      });   
      this.images.splice(value,1);
  }

  render() {
        return (
        <div>
            <button onClick={this.handleClick}>choose</button>
            <p>Points: {this.state.bingoPoints}</p>
            <p>{this.state.status}</p>
            <img alt="" className="cell-img" src={this.state.images}/>
        </div> 
        );
  }
}

