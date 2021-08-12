import { User } from "./user";

export class Activity{
    Id: number;
    UserId:number;
    Activity: string;
    Date:string;
    Description:string;
    Users: User;
}