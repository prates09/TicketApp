import { CommonModule, isPlatformBrowser } from '@angular/common';
import { Component, Inject, PLATFORM_ID, signal, OnInit } from '@angular/core';
import { TicketService } from '../../services/ticket-service';

@Component({
  selector: 'app-tickets',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './tickets.html',
  styleUrl: './tickets.css',
})
export class Tickets implements OnInit {
  tickets = signal<any[]>([]);

  constructor(
    @Inject(PLATFORM_ID) private readonly platformId: object,
    private readonly ticketService: TicketService
  ) {}

  ngOnInit(): void {
    
    if (isPlatformBrowser(this.platformId)) {
      this.ticketService.getTickets().subscribe((data) => this.tickets.set(data));
    }
  }
}
