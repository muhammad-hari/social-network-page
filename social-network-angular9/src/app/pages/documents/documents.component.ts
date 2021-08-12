import { Component, OnInit } from '@angular/core';
import { Documents } from '@app/models/document';
import { DocumentService } from '@app/services/document.service';
import { first } from 'rxjs/operators';

@Component({
  selector: 'app-documents',
  templateUrl: './documents.component.html',
  styleUrls: ['./documents.component.css']
})
export class DocumentsComponent implements OnInit {
  loading = false;
  documents: Documents[];

  constructor(private documentService: DocumentService) { }

  ngOnInit(): void {
    this.loading = true;
    this.documentService.getDocuments().pipe(first()).subscribe(documents => {
        this.loading = false;
        this.documents = documents;
    });
  }


}
