import axios from 'axios';
import { LingoBoard } from '../models/interfaces';

export class BoardService {
    public async getBoard(): Promise<LingoBoard> {
        const url = 'https://localhost:5001/Board/Board';
        try {
            const response = await axios.get<LingoBoard>(url);
            return response.data;
        } catch (exception) {
            return Promise.reject(exception);
        }
    }
}