import {Component} from '@angular/core';

@Component ({
  selector: 'app-books',
  templateUrl: './books.component.html'
})

export class BooksComponent {
  books = ['Primer libro', 'Segundo libro', 'tercer libro'];

  removeBook(book) {
    this.books = this.books.filter( p => p !== book);
  }
}
