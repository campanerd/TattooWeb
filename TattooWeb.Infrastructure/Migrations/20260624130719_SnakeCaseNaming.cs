using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TattooWeb.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SnakeCaseNaming : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppointmentHistories_Appointments_AppointmentId",
                table: "AppointmentHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Artists_ArtistId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Clients_ClientId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Services_ServiceId",
                table: "Appointments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Services",
                table: "Services");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clients",
                table: "Clients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Artists",
                table: "Artists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Appointments",
                table: "Appointments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppointmentHistories",
                table: "AppointmentHistories");

            migrationBuilder.RenameTable(
                name: "Services",
                newName: "services");

            migrationBuilder.RenameTable(
                name: "Clients",
                newName: "clients");

            migrationBuilder.RenameTable(
                name: "Artists",
                newName: "artists");

            migrationBuilder.RenameTable(
                name: "Appointments",
                newName: "appointments");

            migrationBuilder.RenameTable(
                name: "AppointmentHistories",
                newName: "appointment_histories");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "services",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "services",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "services",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Active",
                table: "services",
                newName: "active");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "services",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "DurationMinutes",
                table: "services",
                newName: "duration_minutes");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "clients",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "clients",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "clients",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Cpf",
                table: "clients",
                newName: "cpf");

            migrationBuilder.RenameColumn(
                name: "Allergy",
                table: "clients",
                newName: "allergy");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "clients",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "clients",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "Specialty",
                table: "artists",
                newName: "specialty");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "artists",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "artists",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Cpf",
                table: "artists",
                newName: "cpf");

            migrationBuilder.RenameColumn(
                name: "Bio",
                table: "artists",
                newName: "bio");

            migrationBuilder.RenameColumn(
                name: "Active",
                table: "artists",
                newName: "active");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "artists",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "artists",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "appointments",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Notes",
                table: "appointments",
                newName: "notes");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "appointments",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "appointments",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "ServiceId",
                table: "appointments",
                newName: "service_id");

            migrationBuilder.RenameColumn(
                name: "ScheduledAt",
                table: "appointments",
                newName: "scheduled_at");

            migrationBuilder.RenameColumn(
                name: "DurationMinutes",
                table: "appointments",
                newName: "duration_minutes");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "appointments",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "appointments",
                newName: "client_id");

            migrationBuilder.RenameColumn(
                name: "ArtistId",
                table: "appointments",
                newName: "artist_id");

            migrationBuilder.RenameIndex(
                name: "IX_Appointments_ServiceId",
                table: "appointments",
                newName: "IX_appointments_service_id");

            migrationBuilder.RenameIndex(
                name: "IX_Appointments_ClientId",
                table: "appointments",
                newName: "IX_appointments_client_id");

            migrationBuilder.RenameIndex(
                name: "IX_Appointments_ArtistId",
                table: "appointments",
                newName: "IX_appointments_artist_id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "appointment_histories",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "PreviousValue",
                table: "appointment_histories",
                newName: "previous_value");

            migrationBuilder.RenameColumn(
                name: "NewValue",
                table: "appointment_histories",
                newName: "new_value");

            migrationBuilder.RenameColumn(
                name: "ChangedField",
                table: "appointment_histories",
                newName: "changed_field");

            migrationBuilder.RenameColumn(
                name: "ChangedBy",
                table: "appointment_histories",
                newName: "changed_by");

            migrationBuilder.RenameColumn(
                name: "ChangedAt",
                table: "appointment_histories",
                newName: "changed_at");

            migrationBuilder.RenameColumn(
                name: "AppointmentId",
                table: "appointment_histories",
                newName: "appointment_id");

            migrationBuilder.RenameIndex(
                name: "IX_AppointmentHistories_AppointmentId",
                table: "appointment_histories",
                newName: "IX_appointment_histories_appointment_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_services",
                table: "services",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_clients",
                table: "clients",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_artists",
                table: "artists",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_appointments",
                table: "appointments",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_appointment_histories",
                table: "appointment_histories",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_appointment_histories_appointments_appointment_id",
                table: "appointment_histories",
                column: "appointment_id",
                principalTable: "appointments",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_appointments_artists_artist_id",
                table: "appointments",
                column: "artist_id",
                principalTable: "artists",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_appointments_clients_client_id",
                table: "appointments",
                column: "client_id",
                principalTable: "clients",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_appointments_services_service_id",
                table: "appointments",
                column: "service_id",
                principalTable: "services",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_appointment_histories_appointments_appointment_id",
                table: "appointment_histories");

            migrationBuilder.DropForeignKey(
                name: "FK_appointments_artists_artist_id",
                table: "appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_appointments_clients_client_id",
                table: "appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_appointments_services_service_id",
                table: "appointments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_services",
                table: "services");

            migrationBuilder.DropPrimaryKey(
                name: "PK_clients",
                table: "clients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_artists",
                table: "artists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_appointments",
                table: "appointments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_appointment_histories",
                table: "appointment_histories");

            migrationBuilder.RenameTable(
                name: "services",
                newName: "Services");

            migrationBuilder.RenameTable(
                name: "clients",
                newName: "Clients");

            migrationBuilder.RenameTable(
                name: "artists",
                newName: "Artists");

            migrationBuilder.RenameTable(
                name: "appointments",
                newName: "Appointments");

            migrationBuilder.RenameTable(
                name: "appointment_histories",
                newName: "AppointmentHistories");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Services",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Services",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Services",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "active",
                table: "Services",
                newName: "Active");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Services",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "duration_minutes",
                table: "Services",
                newName: "DurationMinutes");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "Clients",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Clients",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Clients",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "cpf",
                table: "Clients",
                newName: "Cpf");

            migrationBuilder.RenameColumn(
                name: "allergy",
                table: "Clients",
                newName: "Allergy");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Clients",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "Clients",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "specialty",
                table: "Artists",
                newName: "Specialty");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "Artists",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Artists",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "cpf",
                table: "Artists",
                newName: "Cpf");

            migrationBuilder.RenameColumn(
                name: "bio",
                table: "Artists",
                newName: "Bio");

            migrationBuilder.RenameColumn(
                name: "active",
                table: "Artists",
                newName: "Active");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Artists",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "Artists",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "Appointments",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "notes",
                table: "Appointments",
                newName: "Notes");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Appointments",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "Appointments",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "service_id",
                table: "Appointments",
                newName: "ServiceId");

            migrationBuilder.RenameColumn(
                name: "scheduled_at",
                table: "Appointments",
                newName: "ScheduledAt");

            migrationBuilder.RenameColumn(
                name: "duration_minutes",
                table: "Appointments",
                newName: "DurationMinutes");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "Appointments",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "client_id",
                table: "Appointments",
                newName: "ClientId");

            migrationBuilder.RenameColumn(
                name: "artist_id",
                table: "Appointments",
                newName: "ArtistId");

            migrationBuilder.RenameIndex(
                name: "IX_appointments_service_id",
                table: "Appointments",
                newName: "IX_Appointments_ServiceId");

            migrationBuilder.RenameIndex(
                name: "IX_appointments_client_id",
                table: "Appointments",
                newName: "IX_Appointments_ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_appointments_artist_id",
                table: "Appointments",
                newName: "IX_Appointments_ArtistId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "AppointmentHistories",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "previous_value",
                table: "AppointmentHistories",
                newName: "PreviousValue");

            migrationBuilder.RenameColumn(
                name: "new_value",
                table: "AppointmentHistories",
                newName: "NewValue");

            migrationBuilder.RenameColumn(
                name: "changed_field",
                table: "AppointmentHistories",
                newName: "ChangedField");

            migrationBuilder.RenameColumn(
                name: "changed_by",
                table: "AppointmentHistories",
                newName: "ChangedBy");

            migrationBuilder.RenameColumn(
                name: "changed_at",
                table: "AppointmentHistories",
                newName: "ChangedAt");

            migrationBuilder.RenameColumn(
                name: "appointment_id",
                table: "AppointmentHistories",
                newName: "AppointmentId");

            migrationBuilder.RenameIndex(
                name: "IX_appointment_histories_appointment_id",
                table: "AppointmentHistories",
                newName: "IX_AppointmentHistories_AppointmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Services",
                table: "Services",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clients",
                table: "Clients",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Artists",
                table: "Artists",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Appointments",
                table: "Appointments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppointmentHistories",
                table: "AppointmentHistories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppointmentHistories_Appointments_AppointmentId",
                table: "AppointmentHistories",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Artists_ArtistId",
                table: "Appointments",
                column: "ArtistId",
                principalTable: "Artists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Clients_ClientId",
                table: "Appointments",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Services_ServiceId",
                table: "Appointments",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
