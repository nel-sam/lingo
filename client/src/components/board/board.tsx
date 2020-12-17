import React, { Component } from "react";
import './board.scss';
import { LingoCell } from "../../models/interfaces";


export interface IBoardProps {
  boardItems: LingoCell[];
}

export class Board extends Component<IBoardProps, {}> {
  render() {
    return <div className='container'>
    {
      this.props.boardItems.map(function (cellItem) {
        return <img alt="" className="cell-img" src={cellItem.Url}/>;
      })
    };
  </div>
  }
}
