import React, { Component } from "react";


export interface IBoardProps {
  allItems: string[];
  playerBoardItems: string[];
}

export class RandomImage extends Component<IBoardProps, {}> {
  bingoPoints = 0;
  status="";

  state = {
      images: "",
      bingoPoints: 0,
      status: ""
  };

  handleClick = () => {
      var calledIndex = Math.floor((Math.random() * 1000))% this.props.allItems.length ;
      var calledItem = this.props.allItems[calledIndex];

      if(this.props.playerBoardItems.find(pbi =>  pbi === calledItem) ){
        this.bingoPoints += 1;
        this.props.playerBoardItems.splice(calledIndex,1);
      }

      if(this.props.playerBoardItems.length === 0){
          this.status = "winner";
      }

      this.setState({
        images: this.props.allItems[calledIndex],
        bingoPoints: this.bingoPoints,
        status: this.status
      });

      this.props.allItems.splice(calledIndex,1);
  }

  render() {
        return (
        <div>
            <button onClick={this.handleClick}>choose</button>
            <p>Points: {this.state.bingoPoints}</p>
            <p>{this.state.status}</p>
            {
                this.state.images && <img alt="" className="cell-img" src={this.state.images}/>
            }
        </div>
        );
  }
}

