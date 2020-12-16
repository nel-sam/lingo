import React, { Component } from "react";
import './board.scss';


export interface IBoardProps {
  boardItems: string[];
}

export class Board extends Component<IBoardProps, {}> {
  render() {
    return <div className='container'>
    {
      this.props.boardItems.map(function (value) {
        return <img alt="" className="cell-img" src={value}/>;
      })
    };
  </div>
  }
}
