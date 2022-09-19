//import { useDispatch, useSelector } from 'react-redux';
import logo from './assets/logo.svg';
import './styles/App.css';
import { ApiClientService } from './services/apiClientService';
import { BASE_API_URL } from './constants/config/index';
import { TASK_ROUTE } from './constants/task/routeTypes';

async function App() {
  //const dispatch = useDispatch();
  //const tasks = useSelector(state => state.tasks);
  const response = await ApiClientService.get(BASE_API_URL + TASK_ROUTE);
  console.log(response.json());

  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Edit <code>src/App.js</code> and save to reload.
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
      </header>
    </div>
  );
}

export default App;
