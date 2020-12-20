import React, { Component } from "react";
import './board.scss';
import { LingoCell } from "../../models/interfaces";
import Grid from '@material-ui/core/Grid';
export interface IBoardProps {
  boardItems: LingoCell[];
}

export class Board extends Component<IBoardProps, {}> {
  render() {
    return (
    <div>
      <header className="board-header">Player: name</header>
      <Grid container className='container'>
      {
        this.props.boardItems.map(function (cellItem) {
          return (
              <Grid container item className="cell">
                <img alt="" className="cell-img" src={cellItem.Url}/>
              </Grid>
          )
        })
      }
    </Grid>
  </div>)
  }
}
