import './App.scss';
import { RandomImage } from './components/randomImage/randomImage';
import { Board} from "./components/board/board";

function App() { 
  return (
    <div className='App'>
      <header className='App-header'>
        Lingo
      </header>  
      
      <RandomImage></RandomImage>
      <Board></Board>
    </div>
  );
}

export default App;
