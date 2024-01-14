< script type = "application/ld+json" > {
        "@content": "http://schema.org",
        "@type": "Product",
        "aggregateRating": {
            "@type": "AggregateRating",
            "ratingValue": "5",
            "reviewCount": "5"
        },
        "description": "@Model.SmallDescription",
        "name": "@Model.Name",
        "image": "http://www.atriya.com/uploadedImages/package/@Model.Image",
        "offers": {
            "@type": "Offer",
            "availability": "http://schema.org/InStock",
            "price": "@Model.Price",
            "priceCurrency": "تومان"
        },
        "review": [{
                "@type": "Review",
                "author": "Ellie",
                "datePublished": "2011-04-01",
                "description": "The lamp burned out and now I have to replace it.",
                "name": "Not a happy camper",
                "reviewRating": {
                    "@type": "Rating",
                    "bestRating": "5",
                    "ratingValue": "1",
                    "worstRating": "1"
                }
            },
            {
                "@type": "Review",
                "author": "Lucas",
                "datePublished": "2011-03-25",
                "description": "Great microwave for the price. It is small and fits in my apartment.",
                "name": "Value purchase",
                "reviewRating": {
                    "@type": "Rating",
                    "bestRating": "5",
                    "ratingValue": "4",
                    "worstRating": "1"
                }
            }
        ]
    }
    </script>