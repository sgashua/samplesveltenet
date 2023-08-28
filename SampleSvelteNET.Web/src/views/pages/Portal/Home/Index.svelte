<script lang="ts">
    import { get } from "$lib/scripts/ApiService";

    let result: any[];

    const 
        GetData = async () => {
            const response = await get('api/Person/');
            if (!response.success) {
                alert('failed');
                return false;
            }

            result = response.result;
        };

    GetData();
</script>
<table class="table">
    <thead>
        <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Age</th>
        </tr>
    </thead>
    <tbody>
        {#if result && result.length > 0}
            {#each result as row}
                <tr>
                    <td>{row.PersonID}</td>
                    <td>{row.Name}</td>
                    <td>{row.Age}</td>
                </tr>
            {/each}
        {/if}
    </tbody>
</table>