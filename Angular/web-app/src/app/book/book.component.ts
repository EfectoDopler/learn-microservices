import {Component, Input, EventEmitter, Output} from '@angular/core';

@Component ({
  selector: 'app-book',
  templateUrl: './book.component.html',
  styleUrls: ['./book.component.css']
})

export class BookComponent {
  @Input() titleBook: string;
  @Output() bookClicked = new EventEmitter();

  onClick() {
    this.bookClicked.emit();
  }
}
