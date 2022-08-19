import { Component, OnInit } from '@angular/core';
import { TournamentModel } from 'src/app/models/tournament.model';
import { TournamentService } from 'src/app/services/tournament.service';

@Component({
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

  model:TournamentModel[];

  constructor(
    private readonly _tournamentService: TournamentService
  ) { }

  ngOnInit(): void {
    this._tournamentService.getAll().subscribe({

      next: (data) => {this.model=data;},
      error: () => {},
      complete: () => {},

    });
  }

}
