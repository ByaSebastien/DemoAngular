import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { TournamentModel } from '../models/tournament.model';

@Injectable({
  providedIn: 'root'
})
export class TournamentService {

  constructor(
    private readonly _httpClient: HttpClient
  ) { }

  getAll(){
    return this._httpClient.get<TournamentModel[]>(environment.api_base_url + '/Tournament')
  }
}