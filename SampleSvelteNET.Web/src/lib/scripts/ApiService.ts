import { BaseApiUrl } from "$lib/domains/Constants";

export const 
get = async (endpoint: string) => {
    const response = await fetch(`${BaseApiUrl}/${endpoint}`);
	return response.json();
}