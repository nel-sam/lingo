import React, { Component } from 'react';
import './board.scss';
import { LingoCell, LingoPlayer } from '../../models/interfaces';
import Grid from '@material-ui/core/Grid';

export interface IBoardProps {
  playerInfo: LingoPlayer;
}

export class Board extends Component<IBoardProps, {}> {
  render() {
    return (
    <div>
      
      <header className='board-header'> Player: {`${this.props.playerInfo.firstName} ${this.props.playerInfo.lastName}`} </header>
      
      <Grid container className='container'>
      {
        this.props.playerInfo.board.cells.map(function (cellItem) {
          return (
              <Grid key={cellItem.id} container item className='cell'>
                <img alt='' className='cell-img' src={cellItem.url}/>
              </Grid>
          )
        })
      }
    </Grid>
  </div>)
  }
}
