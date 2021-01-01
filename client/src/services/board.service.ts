import axios from 'axios';
import { LingoGame } from '../models/interfaces';

export class BoardService {
    public async getGame(): Promise<LingoGame> {
        const url = 'https://localhost:5001/Game';
        try {
            const response = await axios.get<LingoGame>(url);
            return response.data;
        } catch (exception) {
            return Promise.reject(exception);
        }
    }
}